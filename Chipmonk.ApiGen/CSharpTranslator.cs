using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chipmonk.ApiGen.Models;

namespace Chipmonk.ApiGen {
    public class CSharpTranslator {
        public List<Class> Classes { get; private set; }

        public CSharpTranslator() {
            Classes = new List<Class>();
        }

        public CsDirectory ConstructApi(List<Function> functions) {
            AttachFunctions(functions);
            TranslateMethods();
            BuildConstructors();
            WrapUpClasses();
            return ConvertClassesToDirectory();
        }

        private void AttachFunctions(List<Function> functions) {
            foreach (var function in functions) {
                try {
                    var cl = FindClassForFunction(function);
                    if (cl != null) {
                        cl.Methods = cl.Methods ?? new List<Method>();
                        cl.Methods.Add(new Method() {
                            Name = function.Name.Substring(2),
                            Parameters = function.Parameters,
                            ReturnType = function.ReturnType
                        });
                    }
                } catch (SkipExportingFunction skip) {
                    Console.WriteLine("Failed to export function:\n{0}\n{1}", function.OriginalLine, skip.Message);
                }
            }
        }

        private Class FindClassForFunction(Function function) {
            foreach (var cl in Classes.OrderByDescending(c => c.Name.Length)) {
                if(function.Name.StartsWith("cp" + cl.Name)) {
                    return cl;
                }
            }

            foreach (var cl in Classes) {
                if (function.Parameters.Count > 0 && ClassMatchesType(cl, function.Parameters[0].Type)) {
                    return cl;
                }
            }

            Console.WriteLine("Couldn't find good class for {0}", function.Name);
            return null;
        }

        private void TranslateMethods() {
            foreach (var cl in Classes) {
                if (cl.Methods != null) {
                    var toRemove = new List<Method>();

                    foreach (var method in cl.Methods) {
                        try {
                            TranslateMethod(cl, method);
                        } catch (SkipExportingFunction skip) {
                            Console.WriteLine("Failed to translate method: {0}", skip.Message);
                            toRemove.Add(method);
                        }
                    }

                    cl.Methods = cl.Methods.Except(toRemove).ToList();
                }
            }
        }

        private void TranslateMethod(Class cl, Method method) {
            var firstArgumentIsHandle = false;
            if (method.Parameters.Count > 0 && ClassMatchesType(cl, method.Parameters[0].Type)) {
                method.Parameters = method.Parameters.Skip(1).ToList();
                firstArgumentIsHandle = true;
            }

            foreach (var parameter in method.Parameters) {
                parameter.Name = GetSafeArgumentName(parameter.Name);
            }

            var returnIsClassReference = FindClassForType(method.ReturnType) != null;
            method.ReturnType = ConvertType(method.ReturnType);
            var arguments = method.Parameters.Select(parameter => ConvertParameterToArgument(parameter)).ToList();

            foreach (var parameter in method.Parameters) {
                parameter.Type = ConvertType(parameter.Type);
            }

            if (firstArgumentIsHandle) {
                arguments.Insert(0, "Handle");
            }

            var returnStatement = string.Format("CP.{0}({1})", method.Name, string.Join(", ", arguments));
            if (returnIsClassReference) {
                returnStatement = string.Format("new {0}({1})", method.ReturnType, returnStatement);
            }
            if (method.ReturnType != "void") {
                returnStatement = "return " + returnStatement;
            }
            returnStatement += ";";

            method.Body = new List<Expression>() {
                new Expression(returnStatement)
            };

            if (!firstArgumentIsHandle) {
                method.Static = true;
            }
        }

        private void BuildConstructors() {
            foreach (var cl in Classes) {
                cl.Constructors = cl.Constructors ?? new List<Constructor>();

                if (cl.Parent == null) {
                    BuildConstructorsForClass(cl);
                } else {
                    BuildConstructorsForChildClass(cl);
                }

            }
        }

        private void BuildConstructorsForClass(Class cl) {
            cl.Properties = cl.Properties ?? new List<Property>();
            cl.Properties.Add(new Property("IntPtr", "Handle"));

            var newFunction = FindNewFunction(cl.Methods);
            if (newFunction != null) {
                var arguments = string.Join(", ", newFunction.Parameters.Select(parameter => ConvertParameterToArgument(parameter)));
                cl.Constructors.Add(new Constructor() {
                    Parameters = newFunction.Parameters,
                    Body = new List<Expression>() {
                         new Expression("Handle = CP.{0}({1});",  newFunction.Name, arguments)
                    }
                });
            }

            cl.Constructors.Add(new Constructor() {
                Parameters = new List<Parameter>() {
                    new Parameter("IntPtr", "handle")
                },
                Body = new List<Expression>() {
                    new Expression("Handle = handle;")
                }
            });
        }

        private void BuildConstructorsForChildClass(Class cl) {
            var newFunction = FindNewFunction(cl.Methods);
            if (newFunction != null) {
                var arguments = string.Join(", ", newFunction.Parameters.Select(parameter => ConvertParameterToArgument(parameter)));
                cl.Constructors.Add(new Constructor() {
                    Parameters = newFunction.Parameters,
                    Base = new Expression("CP.{0}({1})",  newFunction.Name, arguments)
                });
            }

            cl.Constructors.Add(new Constructor() {
                Parameters = new List<Parameter>() {
                    new Parameter("IntPtr", "handle")
                },
                Base = new Expression("handle")
            });
        }

        private string ConvertParameterToArgument(Parameter parameter) {
            var cl = FindClassForType(parameter.Type);
            if (cl != null) {
                return parameter.Name + ".Handle";
            } else {
                return parameter.Name;
            }
        }

        private Method FindNewFunction(List<Method> methods) {
            if (methods != null) {
                foreach (var method in methods) {
                    if (method.Name.EndsWith("New") || method.Name.EndsWith("NewRaw")) {
                        return method;
                    }
                }
            }

            return null;
        }

        private void WrapUpClasses() {
            foreach (var cl in Classes) {
                if (cl.Methods != null) {
                    foreach (var method in cl.Methods) {
                        if (method.Name.StartsWith(cl.Name)) {
                            method.Name = method.Name.Substring(cl.Name.Length);
                        }
                    }

                    cl.Methods = cl.Methods.OrderBy(method => method.Name).ToList();
                }
            }
        }

        private CsDirectory ConvertClassesToDirectory() {
            var directory = new CsDirectory();
            directory.Files = new List<CsFile>();
            foreach (var cl in Classes) {
                directory.Files.Add(new CsFile() {
                    UsingStatements = new List<UsingStatement>() {
                        new UsingStatement("System"),
                        new UsingStatement("System.Runtime.InteropServices"),
                        new UsingStatement("Chipmonk.CApi")
                    },
                    Name = cl.Name + ".cs",
                    NamespaceBlocks = new List<NamespaceBlock>() {
                        new NamespaceBlock() {
                            Namespace = "Chipmonk.CSharp",
                            Classes = new List<Class>() {
                                cl
                            }
                        }
                    }
                });
            }

            return directory;
        }

        private Class FindClassForType(string type) {
            return Classes.FirstOrDefault(cl => cl.Name == type || ClassMatchesType(cl, type));
        }

        private bool ClassMatchesType(Class cl, string type) {
            return "cp" + cl.Name + "*" == type ||
                   "const cp" + cl.Name + "*" == type ||
                   (cl.Parent != null && ClassMatchesType(cl.Parent, type));
        }

        private static List<string> passthroughTypes = new List<string>() {
            "void",
            "string",
            "int",
            "params object[]"
        };

        private static Dictionary<string, string> remapTypes = new Dictionary<string, string>() {
            { "cpFloat", "double" },
            { "cpBool", "bool" },
            { "const int", "int" },
            { "unsigned long", "UInt64" },
            { "cpVect", "Vect" },
            { "const cpVect", "Vect" },
            { "cpBB", "BB" },
            { "const cpBB", "BB" },
            { "cpDataPointer", "IntPtr" },
            { "cpBodyType", "BodyType" }
        };

        private string ConvertType(string returnType) {
            var cl = FindClassForType(returnType);

            if (passthroughTypes.Contains(returnType)) {
                return returnType;
            } else if (remapTypes.ContainsKey(returnType)) {
                return remapTypes[returnType];
            } else if (cl != null) {
                return cl.Name;
            } else if (returnType.EndsWith("*")) {
                return "IntPtr";
            } else {
                throw new SkipExportingFunction("Don't know how to convert type: " + returnType);
            }
        }

        private string GetSafeArgumentName(string argumentName) {
            if (argumentName == "out") {
                return "output";
            }

            return argumentName;
        }
    }
}

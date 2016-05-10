using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chipmonk.ApiGen.Models;

namespace Chipmonk.ApiGen {
    public class CApiTranslator {
        public CsFile TranslateFunctions(List<Function> functions) {
            var methods = new List<Method>();
            foreach (var function in functions) {
                try {
                    methods.Add(TranslateFunction(function));
                } catch (SkipExportingFunction skip) {
                    Console.WriteLine("Failed to export function:\n{0}\n{1}", function.OriginalLine, skip.Message);
                }
            }

            methods = methods.OrderBy((meth) => meth.Name).ToList();

            var file = new CsFile() {
                Name = "CP",
                UsingStatements = new List<UsingStatement>() {
                    new UsingStatement("System"),
                    new UsingStatement("System.Runtime.InteropServices")
                },
                NamespaceBlocks = new List<NamespaceBlock>() {
                    new NamespaceBlock() {
                        Namespace = "Chipmonk.CApi",
                        Classes = new List<Class>() {
                            new Class() {
                                Name = "CP",
                                Methods = methods,
                                Static = true
                            }
                        }
                    }
                }
            };

            return file;
        }


        private Method TranslateFunction(Function function) {
            return new Method() {
                Comments = new List<string>() {
                    function.OriginalLine
                },
                Attributes = new List<CsAttribute>() {
                    new CsAttribute() {
                        Name = "DllImport",
                        Arguments = new List<string>() {
                            "\"chipmunk.dll\""
                        },
                        NamedArguments = new List<NamedArgument>() {
                            new NamedArgument("CallingConvention", "CallingConvention.Cdecl"),
                            new NamedArgument("EntryPoint", "\"" + function.Name + "\"")
                        }
                    }
                },
                ReturnType = ConvertType(function.ReturnType),
                Name = function.Name.Substring(2),
                Parameters = function.Parameters
                                    .Select(arg => new Parameter() {
                                                       Type = ConvertType(arg.Type),
                                                       Name = GetSafeArgumentName(arg.Name)
                                                   })
                                    .ToList(),
                Static = true,
                Extern = true
            };
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
            { "unsigned long", "ulong" },
            { "cpVect", "Vect" },
            { "const cpVect", "Vect" },
            { "cpBB", "BB" },
            { "const cpBB", "BB" },
            { "cpDataPointer", "IntPtr" },
            { "cpBodyType", "BodyType" },
            { "cpTransform", "Transform" },
            { "cpCollisionType", "uint" },
            { "cpContactPointSet", "ContactPointSet" },
            { "cpShapeFilter", "ShapeFilter" },
            { "cpTimestamp", "uint" }
        };

        private static string ConvertType(string returnType) {
            if (passthroughTypes.Contains(returnType)) {
                return returnType;
            } else if (remapTypes.ContainsKey(returnType)) {
                return remapTypes[returnType];
            } else if (returnType.EndsWith("*")) {
                return "IntPtr";
            } else if (returnType.EndsWith("Func")) {
                return "IntPtr";
            } else {
                throw new SkipExportingFunction("Don't know how to convert type: " + returnType);
            }
        }

        private static string GetSafeArgumentName(string argumentName) {
            if (argumentName == "out") {
                return "output";
            }

            return argumentName;
        }
    }
}

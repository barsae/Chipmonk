using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.ApiGen {
    public class ApiBuilder {
        public List<Class> Classes { get; private set; }
        public List<Function> StaticFunctions { get; private set; }

        private string currentNamespace;

        public ApiBuilder() {
            Classes = new List<Class>();
            StaticFunctions = new List<Function>();
        }

        public void AddFunction(Function function) {
            var cl = Classes.OrderByDescending(c => c.ClassName.Length)
                            .FirstOrDefault(c => function.FunctionName.StartsWith("cp" + c.ClassName));
            if (cl != null) {
                var translated = new Function() {
                    OriginalLine =  function.OriginalLine,
                    FunctionName = function.FunctionName.Substring(cl.ClassName.Length + 2),
                    ReturnType = ConvertType(function.ReturnType),
                    Arguments = function.Arguments
                                        .Select(arg => new Argument() {
                                            ArgumentName = GetSafeArgumentName(arg.ArgumentName),
                                            ArgumentType = ConvertType(arg.ArgumentType)
                                        })
                                        .ToList()
                };
                cl.Functions.Add(translated);
            } else {
                StaticFunctions.Add(function);
            }
        }

        public void AddClass(string name, string shorthand) {
            Classes.Add(new Class() {
                ClassName = name,
                Shorthand = shorthand,
                Namespace = currentNamespace
            });
        }

        public void SetNamespace(string name) {
            currentNamespace = name;
        }

        public void WriteToDirectory(string directory) {
            foreach (var cl in Classes) {
                var filename = Path.Combine(directory, cl.ClassName) + ".cs";
                cl.WriteToFile(filename);
            }
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
            //{ "cpBody*", "Body" }
        };

        private static string ConvertType(string returnType) {
            if (passthroughTypes.Contains(returnType)) {
                return returnType;
            } else if (remapTypes.ContainsKey(returnType)) {
                return remapTypes[returnType];
            } else if (returnType.EndsWith("*")) {
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

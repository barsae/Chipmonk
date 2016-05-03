using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.ApiGen {
    public class CToCSharpFunctionTranslator {
        public Function TranslateFunction(Function function) {
            return new Function() {
                OriginalLine = function.OriginalLine,
                ReturnType = ConvertType(function.ReturnType),
                FunctionName = function.FunctionName,
                Arguments = function.Arguments
                                    .Select(arg => new Argument() {
                                                       ArgumentType = ConvertType(arg.ArgumentType),
                                                       ArgumentName = GetSafeArgumentName(arg.ArgumentName)
                                                   })
                                    .ToList()
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
            { "unsigned long", "UInt64" },
            { "cpVect", "Vect" },
            { "const cpVect", "Vect" },
            { "cpBB", "BB" },
            { "const cpBB", "BB" },
            { "cpDataPointer", "IntPtr" },
            { "cpBodyType", "BodyType" }
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Chipmonk.ApiGen {
    public class Class {
        public string ClassName { get; set; }
        public string Shorthand { get; set; }
        public string Namespace { get; set; }
        public List<Function> Functions { get; set; }

        private static List<string> functionsToOmit = new List<string>() {
            "Alloc",
            "Free",
            "New",
            "Init",
            "Destroy"
        };

        public Class() {
            Functions = new List<Function>();
        }

        public void WriteToFile(string filename) {
            var code = new CSharpBuilder();
            code.AddUsings("System", "System.Runtime.InteropServices", "Chipmonk.CApi");
            code.StartNamespace(Namespace);
            code.StartClass(ClassName);

            code.AppendLine("public IntPtr {0} {{ get; private set; }}", Shorthand);
            code.AppendLine();

            CreateConstructor(code);

            foreach (var function in Functions) {
                if (!functionsToOmit.Contains(function.FunctionName)) {
                    if (function.Arguments.Count > 0 && function.Arguments[0].ArgumentName == Shorthand) {
                        CreateWrapperFunction(code, function);
                    } else {
                        code.AddExternalFunction(function);
                    }
                }
            }

            code.End();
            code.End();

            File.WriteAllText(filename, code.ToString());
        }

        private void CreateConstructor(CSharpBuilder code) {
            var newFunction = Functions.FirstOrDefault(function => function.FunctionName == "New");

            if (newFunction != null) {
                // Signature
                code.Append("public {0}(", ClassName);
                bool first = true;
                foreach (var argument in newFunction.Arguments) {
                    if (!first) {
                        code.Append(", ");
                    }
                    first = false;
                    code.Append(argument.ArgumentType);
                    code.Append(" ");
                    code.Append(argument.ArgumentName);
                }
                code.AppendLine(") {{");
                code.Indent();

                // Body
                code.Append("{0} = CP.{1}New(", Shorthand, ClassName);
                first = true;
                foreach (var argument in newFunction.Arguments) {
                    if (!first) {
                        code.Append(", ");
                    }
                    first = false;
                    code.Append(argument.ArgumentName);
                }
                code.AppendLine(");");

                // Closing
                code.Dedent();
                code.AppendLine("}}");
                code.AppendLine();
            }
        }

        private void CreateWrapperFunction(CSharpBuilder code, Function function) {
            code.AppendLine("// {0}", function.OriginalLine);

            // Signature
            code.Append("public {0} {1}(", function.ReturnType, function.FunctionName);
            bool first = true;
            foreach (var argument in function.Arguments.Skip(1)) {
                if (!first) {
                    code.Append(", ");
                }
                first = false;
                code.Append(argument.ArgumentType);
                code.Append(" ");
                code.Append(argument.ArgumentName);
            }
            code.AppendLine(") {{");
            code.Indent();

            // Body
            if (function.ReturnType != "void") {
                code.Append("return ");
            }
            code.Append("CP.{0}{1}({2}", ClassName, function.FunctionName, Shorthand);
            foreach (var argument in function.Arguments.Skip(1)) {
                code.Append(", ");
                code.Append(argument.ArgumentName);
            }
            code.AppendLine(");");

            // Closing
            code.Dedent();
            code.AppendLine("}}");
            code.AppendLine();
        }
    }
}


namespace Chipmonk.ApiGen {
    public class CSharpBuilder : CodeBuilder {
        public CSharpBuilder() {
        }

        public void AddUsings(params string[] usings) {
            foreach (var statement in usings) {
                AppendLine("using {0};", statement);
            }
            AppendLine();
        }

        public void StartNamespace(string name) {
            AppendLine("namespace {0} {{", name);
            Indent();
        }

        public void StartClass(string name) {
            AppendLine("public class {0} {{", name);
            Indent();
        }

        public void StartStaticClass(string name) {
            AppendLine("public static class {0} {{", name);
            Indent();
        }

        public void AddExternalFunction(Function function) {
            AppendLine("// {0}", function.OriginalLine);
            AppendLine(@"[DllImport(""chipmunk.dll"", CallingConvention = CallingConvention.Cdecl, EntryPoint = ""cp{0}"")]", function.FunctionName);
            Append("public static extern {0} {1}(", function.ReturnType, function.FunctionName);

            bool first = true;
            foreach (var argument in function.Arguments) {
                if (!first) {
                    Append(", ");
                }
                first = false;

                Append(argument.ArgumentType);
                Append(" ");
                Append(argument.ArgumentName);
            }

            AppendLine(");");
            AppendLine();
        }

        public void End() {
            Dedent();
            AppendLine("}}");
        }
    }
}

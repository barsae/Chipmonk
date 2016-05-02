
namespace Chipmonk.ApiGen {
    public class CSharpBuilder {
        public CodeBuilder Code { get; private set; }

        public CSharpBuilder() {
            Code = new CodeBuilder();
        }

        public void AddUsings(params string[] usings) {
            foreach (var statement in usings) {
                Code.AddLine("using {0};", statement);
            }
            Code.AppendLine();
        }

        public void StartNamespace(string name) {
            Code.AddLine("namespace {0} {{", name);
            Code.Indent();
        }

        public void StartClass(string name) {
            Code.AddLine("public static class {0} {{", name);
            Code.Indent();
        }

        public void AddFunction(Function function) {
            var name = function.FunctionName.Substring(2);
            Code.AddLine(@"[DllImport(""chipmunk.dll"", CallingConvention = CallingConvention.Cdecl, EntryPoint = ""cp{0}"")]", name);
            Code.Append("public static extern {0} {1}(", function.ReturnType, name);

            bool first = true;
            foreach (var argument in function.Arguments) {
                if (!first) {
                    Code.Append(", ");
                }
                first = false;

                Code.Append(argument.ArgumentType);
                Code.Append(" ");
                Code.Append(argument.ArgumentName);
            }

            Code.AddLine(");");
            Code.AppendLine();
        }

        public void End() {
            Code.Dedent();
            Code.AddLine("}}");
        }

        public override string ToString() {
            return Code.ToString();
        }
    }
}

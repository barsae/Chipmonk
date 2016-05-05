using System;
using System.Collections.Generic;
using Chipmonk.ApiGen.Models;

namespace Chipmonk.ApiGen {
    public class CSharpWriter {
        public CSharpWriter() {
        }

        public void Write(CodeBuilder code, CsFile file) {
            foreach (var usingStatement in file.UsingStatements) {
                code.AppendLine("using {0};", usingStatement.Directive);
            }
            code.AppendLine();

            foreach (var namespaceBlock in file.NamespaceBlocks) {
                code.AppendLine("namespace {0} {{", namespaceBlock.Namespace);
                code.Indent();

                Write(code, namespaceBlock.Classes);

                code.Dedent();
                code.AppendLine("}}");
            }

            Write(code, file.Classes);
        }

        private void Write(CodeBuilder code, List<Class> classes) {
            if (classes != null) {
                foreach (var cl in classes) {
                    Write(code, cl);
                }
            }
        }

        public void Write(CodeBuilder code, Class cl) {
            code.AppendLine("public {0}class {1} {{",
                            cl.Static ? "static " : "",
                            cl.Name);
            code.Indent();

            if (cl.Methods != null) {
                foreach (var method in cl.Methods) {
                    Write(code, method);
                }
            }

            code.Dedent();
            code.AppendLine("}}");
        }

        public void Write(CodeBuilder code, Method method) {
            Write(code, method.Attributes);

            code.Append("public {0}{1}{2} {3}(",
                        method.Static ? "static " : "",
                        method.Extern ? "extern ": "",
                        method.ReturnType,
                        method.Name);

            code.StartSeparatedList(", ");
            foreach (var argument in method.Arguments) {
                code.Append("{0} {1}", argument.Type, argument.Name);
            }
            code.EndSeparatedList();

            if (method.Extern) {
                code.AppendLine(");");
                code.AppendLine();
            } else {
                throw new NotImplementedException();
            }
        }

        public void Write(CodeBuilder code, List<CsAttribute> attributes) {
            if (attributes != null) {
                foreach (var attribute in attributes) {
                    Write(code, attribute);
                }
            }
        }

        public void Write(CodeBuilder code, CsAttribute attribute) {
            code.Append("[{0}(", attribute.Name);
            code.StartSeparatedList(", ");

            if (attribute.Arguments != null) {
                foreach (var argument in attribute.Arguments) {
                    code.Append(argument);
                }
            }

            if (attribute.NamedArguments != null) {
                foreach (var argument in attribute.NamedArguments) {
                    code.Append("{0} = {1}", argument.Name, argument.Value);
                }
            }

            code.EndSeparatedList();
            code.AppendLine(")]");
        }
    }
}

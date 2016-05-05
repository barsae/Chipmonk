using System;
using System.Collections.Generic;
using System.IO;
using Chipmonk.ApiGen.Models;

namespace Chipmonk.ApiGen {
    public class CSharpWriter {
        public CSharpWriter() {
        }

        public void Write(CsDirectory directory) {
            if (directory.Files != null) {
                foreach (var file in directory.Files) {
                    var code = new CodeBuilder();
                    Write(code, file);
                    var filename = Path.Combine(directory.Name, file.Name);
                    File.WriteAllText(filename, code.ToString());
                }
            }
        }

        public void Write(CodeBuilder code, CsFile file) {
            if (file.UsingStatements != null) {
                foreach (var usingStatement in file.UsingStatements) {
                    code.AppendLine("using {0};", usingStatement.Directive);
                }
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
            code.Append("public {0}class {1} ",
                        cl.Static ? "static " : "",
                        cl.Name);
            if (cl.Parent != null) {
                code.Append(": {0} ", cl.Parent.Name);
            }
            code.AppendLine("{{");
            code.Indent();

            if (cl.Properties != null) {
                foreach (var property in cl.Properties) {
                    Write(code, property);
                }
                code.AppendLine();
            }

            if (cl.Constructors != null) {
                foreach (var constructor in cl.Constructors) {
                    Write(code, cl, constructor);
                }
            }

            if (cl.Methods != null) {
                foreach (var method in cl.Methods) {
                    Write(code, method);
                }
            }

            code.Dedent();
            code.AppendLine("}}");
        }

        private void Write(CodeBuilder code, Property property) {
            code.AppendLine("public {0} {1} {{ get; set; }}", property.Type, property.Name);
        }

        private void Write(CodeBuilder code, Class cl, Constructor constructor) {
            code.Append("public {0}(", cl.Name);

            code.StartSeparatedList(", ");
            if (constructor.Parameters != null) {
                foreach (var parameter in constructor.Parameters) {
                    code.Append("{0} {1}", parameter.Type, parameter.Name);
                }
            }
            code.EndSeparatedList();
            code.Append(")");

            if (constructor.Base != null) {
                code.Append(" : base({0})", constructor.Base.Statement);
            }

            code.AppendLine(" {{");

            code.Indent();
            Write(code, constructor.Body);
            code.Dedent();

            code.AppendLine("}}");
            code.AppendLine();
        }

        public void Write(CodeBuilder code, Method method) {
            if (method.Comments != null) {
                foreach (var comment in method.Comments) {
                    code.AppendLine("// {0}", comment);
                }
            }

            Write(code, method.Attributes);

            code.Append("public {0}{1}{2} {3}(",
                        method.Static ? "static " : "",
                        method.Extern ? "extern ": "",
                        method.ReturnType,
                        method.Name);

            code.StartSeparatedList(", ");
            foreach (var parameter in method.Parameters) {
                code.Append("{0} {1}", parameter.Type, parameter.Name);
            }
            code.EndSeparatedList();

            if (method.Extern) {
                code.AppendLine(");");
                code.AppendLine();
            } else {
                code.AppendLine(") {{");

                code.Indent();
                Write(code, method.Body);
                code.Dedent();

                code.AppendLine("}}");
                code.AppendLine();
            }
        }

        public void Write(CodeBuilder code, List<Expression> expressions) {
            if (expressions != null) {
                foreach (var expression in expressions) {
                    code.AppendLine(expression.Statement);
                }
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

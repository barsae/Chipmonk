using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chipmonk.ApiGen {
    public class Program {
        public static void Main(string[] args) {
            var includeDirectory = @"C:\Users\barsae\Dropbox\code\Chipmunk2D\include\chipmunk";

            using (var outputFile = new StreamWriter(@"C:\Users\barsae\Dropbox\code\Chipmonk\Chipmonk\CP.cs")) {
                outputFile.WriteLine(@"using System;
using System.Runtime.InteropServices;

namespace Chipmonk {
    public static class CP {");

                foreach (var statement in GetExportStatements(includeDirectory)) {
                    try {
                        var export = ParseExportStatement(statement);

                        var name = export.FunctionName.Substring(2);
                        var arguments = string.Join(", ",
                                                    export.Arguments.Select(arg => string.Format("{0} {1}",
                                                                                                 ConvertType(arg.ArgumentType), 
                                                                                                 GetSafeArgumentName(arg.ArgumentName))));

                        outputFile.WriteLine(@"        [DllImport(""chipmunk.dll"", CallingConvention = CallingConvention.Cdecl, EntryPoint = ""cp{0}"")]
        public static extern {1} {0}({2});
",
                                             name,
                                             ConvertType(export.ReturnType),
                                             arguments);
                    } catch (SkipExportingFunction skip) {
                        Console.WriteLine("Skipped:\n    {0}\n{1}", statement, skip.Message);
                    }
                }

                outputFile.WriteLine(@"    }
}");
            }

            Console.WriteLine("Done");
            Console.ReadKey(true);
        }

        private static IEnumerable<string> GetExportStatements(string includeDirectory) {
            var exportRegex = new Regex("^CP_EXPORT.*");

            foreach (var file in Directory.GetFiles(includeDirectory)) {
                foreach (var line in File.ReadAllLines(file)) {
                    var match = exportRegex.Match(line);

                    if (match.Success) {
                        yield return line;
                    }
                }
            }
        }

        private static ExportedFunction ParseExportStatement(string statement) {
            var openCount = statement.Where(c => c == '(').Count();
            var closeCount = statement.Where(c => c == ')').Count();

            if (openCount != closeCount) {
                throw new SkipExportingFunction("Unbalanced parantheses");
            }

            var regex = new Regex(@"^CP_EXPORT (\w+)( ?\* ?)? ?(\w+)\((.*)\);");

            var match = regex.Match(statement);
            if (match.Success) {
                var returnType = match.Groups[1].Value + match.Groups[2].Value.Trim();
                var name = match.Groups[3].Value;
                var rawArguments = match.Groups[4].Value;
                var arguments = ParseArguments(rawArguments).ToList();

                return new ExportedFunction() {
                    FunctionName = name,
                    ReturnType = returnType,
                    Arguments = arguments
                };
            } else {
                throw new SkipExportingFunction("Doesn't look like a function");
            }
        }

        private static IEnumerable<Argument> ParseArguments(string rawArguments) {
            if (rawArguments.Trim() != "void") {
                var regex = new Regex(@"((?:const )?(?:unsigned )?\w+)( ?(?:\*|\*\*) ?)? ?(\w+)");

                var arguments = rawArguments.Split(',').Select(arg => arg.Trim());
                foreach (var argument in arguments) {
                    if (argument == "...") {
                        yield return new Argument() {
                            ArgumentName = "varargs",
                            ArgumentType = "params object[]"
                        };
                    } else {
                        var match = regex.Match(argument);
                        yield return new Argument() {
                            ArgumentName = match.Groups[3].Value,
                            ArgumentType = match.Groups[1].Value + match.Groups[2].Value.Trim()
                        };
                    }
                }
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

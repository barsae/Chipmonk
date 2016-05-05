using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Chipmonk.ApiGen.Models;

namespace Chipmonk.ApiGen.C {
    public class CFunctionParser {
        public Function ParseExportStatement(string statement) {
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

                return new Function() {
                    OriginalLine = statement,
                    Name = name,
                    ReturnType = returnType,
                    Parameters = arguments
                };
            } else {
                throw new SkipExportingFunction("Doesn't look like a function");
            }
        }

        private IEnumerable<Parameter> ParseArguments(string rawArguments) {
            if (rawArguments.Trim() != "void") {
                var regex = new Regex(@"((?:const )?(?:unsigned )?\w+)( ?(?:\*|\*\*) ?)? ?(\w+)");

                var arguments = rawArguments.Split(',').Select(arg => arg.Trim());
                foreach (var argument in arguments) {
                    if (argument == "...") {
                        yield return new Parameter() {
                            Name = "varargs",
                            Type = "params object[]"
                        };
                    } else {
                        var match = regex.Match(argument);
                        yield return new Parameter() {
                            Name = match.Groups[3].Value,
                            Type = match.Groups[1].Value + match.Groups[2].Value.Trim()
                        };
                    }
                }
            }
        }
    }
}

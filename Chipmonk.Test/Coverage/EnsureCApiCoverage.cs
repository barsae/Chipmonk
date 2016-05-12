using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chipmonk.Test.Coverage {
    [TestClass]
    public class EnsureCApiCoverage {
        public const string C_API_TEST_PATH = @"..\..\CApi";
        public const string C_API_FILE = @"..\..\..\Chipmonk\CApi\CP.cs";

        [TestMethod]
        public void EnsureCoverageIsComplete() {
            var functions = new HashSet<string>();

            var functionDeclaration = new Regex(@"public static extern .*? (\w*?)\(.*?\);");
            foreach (var line in File.ReadAllLines(C_API_FILE)) {
                var match = functionDeclaration.Match(line);
                if (match.Success) {
                    functions.Add(match.Groups[1].Value);
                }
            }
            var initialCount = functions.Count;

            var functionUsage = new Regex(@"CP\.(\w*?)\(.*?\)");
            foreach (var file in Directory.EnumerateFiles(C_API_TEST_PATH)) {
                foreach (var line in File.ReadAllLines(file)) {
                    var match = functionUsage.Match(line);
                    if (match.Success) {
                        Debug.WriteLine(match.Groups[1].Value);
                        functions.Remove(match.Groups[1].Value);
                    }
                }
            }
            var finalCount = functions.Count;

            Assert.Fail("The following {0}/{1} functions are not covered:\n{2}", finalCount, initialCount, string.Join("\n", functions.OrderBy(function => function)));
        }
    }
}

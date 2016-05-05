using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Chipmonk.ApiGen.Models;

namespace Chipmonk.ApiGen.C {
    public class HeaderFileReader {
        public List<Function> ReadFunctionsFromDirectory(string directory) {
            var reader = new DirectoryReader();
            var parser = new CFunctionParser();
            var exportFilter = new Regex("^CP_EXPORT.*");

            var originalFunctions = new List<Function>();
            foreach (var line in reader.ReadAllLines(directory, exportFilter)) {
                try {
                    originalFunctions.Add(parser.ParseExportStatement(line));
                } catch (SkipExportingFunction skip) {
                    Console.WriteLine("Failed to export function:\n{0}\n{1}", line, skip.Message);
                }
            }

            return originalFunctions;
        }
    }
}

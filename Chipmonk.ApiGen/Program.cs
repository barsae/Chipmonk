using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chipmonk.ApiGen {
    public static class Program {
        public static void Main(string[] args) {
            var includeDirectory = @"C:\Users\barsae\Dropbox\code\Chipmunk2D\include\chipmunk";
            var exportFilter = new Regex("^CP_EXPORT.*");
            var reader = new DirectoryReader();
            var parser = new CFunctionParser();
            var translater = new CToCSharpFunctionTranslator();
            var writer = new CSharpBuilder();

            writer.AddUsings("System", "System.Runtime.InteropServices");
            writer.StartNamespace("Chipmonk");
            writer.StartClass("CP");

            var parsedFunctions = new List<Function>();

            foreach (var line in reader.ReadAllLines(includeDirectory, exportFilter)) {
                try {
                    parsedFunctions.Add(parser.ParseExportStatement(line));
                } catch (SkipExportingFunction skip) {
                    Console.WriteLine("Failed to export function:\n{0}\n{1}", line, skip.Message);
                }
            }

            parsedFunctions.Select(x => x).HandleException<Function, SkipExportingFunction>((ex) => Console.WriteLine(ex.Message));

            foreach (var parsedFunction in parsedFunctions.OrderBy(f => f.FunctionName)) {
                try {
                    var translatedFunction = translater.TranslateFunction(parsedFunction);
                    writer.AddFunction(translatedFunction);
                } catch (SkipExportingFunction skip) {
                    Console.WriteLine("Failed to export function:\n{0}\n{1}", parsedFunction.FunctionName, skip.Message);
                }
            }

            writer.End();
            writer.End();

            File.WriteAllText(@"C:\Users\barsae\Dropbox\code\Chipmonk\Chipmonk\CApi\CP.cs", writer.ToString());
            Console.WriteLine("Done");
            Console.ReadKey(true);
        }

        //
        public static IEnumerable<T> HandleException<T, ExceptionType>(this IEnumerable<T> enumerable, Action<ExceptionType> action) where ExceptionType : Exception {
            var enumerator = enumerable.GetEnumerator();
            while (true) {
                try {
                    if (!enumerator.MoveNext()) {
                        break;
                    }
                } catch(ExceptionType ex) {
                    action(ex);
                }

                yield return enumerator.Current;
            }
        }
    }
}

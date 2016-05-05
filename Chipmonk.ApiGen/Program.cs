using System;
using System.Collections.Generic;
using System.IO;
using Chipmonk.ApiGen.C;

namespace Chipmonk.ApiGen {
    public static class Program {
        public static void Main(string[] args) {
            var includeDirectory = @"C:\Users\barsae\Dropbox\code\Chipmunk2D\include\chipmunk";
            var cApiOutputFile = @"C:\Users\barsae\Dropbox\code\Chipmonk\Chipmonk\CApi\CP.cs";
            //var cSharpApiOutputDirectory = @"C:\Users\barsae\Dropbox\code\Chipmonk\Chipmonk\CSharp";

            var reader = new HeaderFileReader();
            var translator = new CApiTranslator();
            var code = new CodeBuilder();
            var writer = new CSharpWriter();

            var originalFunctions = reader.ReadFunctionsFromDirectory(includeDirectory);

            var cApi = translator.TranslateFunctions(originalFunctions);
            writer.Write(code, cApi);

            File.WriteAllText(cApiOutputFile, code.ToString());

            //var translater = new CToCSharpFunctionTranslator();
            //var api = new ApiBuilder();
            //var writer = new CSharpBuilder();

            //writer.AddUsings("System", "System.Runtime.InteropServices");
            //writer.StartNamespace("Chipmonk.CApi");
            //writer.StartStaticClass("CP");

            //api.SetNamespace("Chipmonk.CSharp");
            //api.AddClass("Arbiter", "arb");
            //api.AddClass("Body", "body");
            //api.AddClass("CircleShape", "shape");
            //api.AddClass("Constraint", "constraint");
            //api.AddClass("DampedRotarySpring", "constraint");
            //api.AddClass("GearJoint", "constraint");
            //api.AddClass("GrooveJoint", "constraint");
            //api.AddClass("PinJoint", "constraint");
            //api.AddClass("PivotJoint", "constraint");
            //api.AddClass("Polyline", "line");
            //api.AddClass("PolylineSet", "set");
            //api.AddClass("PolyShape", "shape");
            //api.AddClass("RatchetJoint", "constraint");
            //api.AddClass("RotaryJoint", "constraint");
            //api.AddClass("SegmentShape", "shape");
            //api.AddClass("Shape", "shape");
            //api.AddClass("SimpleMotor", "motor");
            //api.AddClass("SlideJoint", "constraint");
            //api.AddClass("Space", "space");

            //foreach (var originalFunction in originalFunctions.OrderBy(f => f.FunctionName)) {
            //    try {
            //        var translatedFunction = translater.TranslateFunction(originalFunction);
            //        translatedFunction.FunctionName = translatedFunction.FunctionName.Substring(2);
            //        writer.AddExternalFunction(translatedFunction);
            //        //api.AddFunction(originalFunction);
            //    } catch (SkipExportingFunction skip) {
            //        Console.WriteLine("Failed to export function:\n{0}\n{1}", originalFunction.OriginalLine, skip.Message);
            //    }
            //}

            //writer.End();
            //writer.End();

            //api.WriteToDirectory(cSharpApiOutputDirectory);

            //File.WriteAllText(cApiOutputFile, writer.ToString());
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

using System;
using System.Collections.Generic;
using System.IO;
using Chipmonk.ApiGen.C;
using Chipmonk.ApiGen.Models;

namespace Chipmonk.ApiGen {
    public static class Program {
        public static void Main(string[] args) {
            var includeDirectory = @"C:\Users\barsae\Dropbox\code\Chipmunk2D\include\chipmunk";
            var cApiOutputFile = @"C:\Users\barsae\Dropbox\code\Chipmonk\Chipmonk\CApi\CP.cs";
            var cSharpApiOutputDirectory = @"C:\Users\barsae\Dropbox\code\Chipmonk\Chipmonk\CSharp";

            var reader = new HeaderFileReader();
            var cApiTranslator = new CApiTranslator();
            var code = new CodeBuilder();
            var writer = new CSharpWriter();

            var originalFunctions = reader.ReadFunctionsFromDirectory(includeDirectory);

            var cApi = cApiTranslator.TranslateFunctions(originalFunctions);
            writer.Write(code, cApi);
            File.WriteAllText(cApiOutputFile, code.ToString());

            var cSharpTranslator = new CSharpTranslator();

            cSharpTranslator.Classes.Add(new Class() { Name = "Arbiter" });
            cSharpTranslator.Classes.Add(new Class() { Name = "BBTree" });
            cSharpTranslator.Classes.Add(new Class() { Name = "Body" });
            cSharpTranslator.Classes.Add(new Class() { Name = "Space" });
            cSharpTranslator.Classes.Add(new Class() { Name = "SimpleMotor" });

            var shape = new Class() { Name = "Shape" };
            cSharpTranslator.Classes.Add(shape);
            cSharpTranslator.Classes.Add(new Class() { Name = "CircleShape", Parent = shape });
            cSharpTranslator.Classes.Add(new Class() { Name = "Polyline", Parent = shape });
            cSharpTranslator.Classes.Add(new Class() { Name = "PolylineSet", Parent = shape });
            cSharpTranslator.Classes.Add(new Class() { Name = "PolyShape", Parent = shape });
            cSharpTranslator.Classes.Add(new Class() { Name = "SegmentShape", Parent = shape });

            var constraint = new Class() { Name = "Constraint" };
            cSharpTranslator.Classes.Add(constraint);
            cSharpTranslator.Classes.Add(new Class() { Name = "DampedSpring", Parent = constraint });
            cSharpTranslator.Classes.Add(new Class() { Name = "DampedRotarySpring", Parent = constraint });
            cSharpTranslator.Classes.Add(new Class() { Name = "GearJoint", Parent = constraint });
            cSharpTranslator.Classes.Add(new Class() { Name = "GrooveJoint", Parent = constraint });
            cSharpTranslator.Classes.Add(new Class() { Name = "PinJoint", Parent = constraint });
            cSharpTranslator.Classes.Add(new Class() { Name = "PivotJoint", Parent = constraint });
            cSharpTranslator.Classes.Add(new Class() { Name = "RatchetJoint", Parent = constraint });
            cSharpTranslator.Classes.Add(new Class() { Name = "RotaryLimitJoint", Parent = constraint });
            cSharpTranslator.Classes.Add(new Class() { Name = "SlideJoint", Parent = constraint });

            var cSharp = cSharpTranslator.ConstructApi(originalFunctions);
            cSharp.Name = cSharpApiOutputDirectory;
            writer.Write(cSharp);

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

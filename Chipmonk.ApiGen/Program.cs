using System;
using System.Collections.Generic;
using System.IO;
using Chipmonk.ApiGen.C;
using Chipmonk.ApiGen.Models;

namespace Chipmonk.ApiGen {
    public static class Program {
        public static void Main(string[] args) {
            var includeDirectory = @"C:\Users\barsa_000\Dropbox\code\Chipmunk2D\include\chipmunk";
            var cApiOutputFile = @"C:\Users\barsa_000\Dropbox\code\Chipmonk\Chipmonk\CApi\CP.cs";

            var reader = new HeaderFileReader();
            var cApiTranslator = new CApiTranslator();
            var code = new CodeBuilder();
            var writer = new CSharpWriter();

            var originalFunctions = reader.ReadFunctionsFromDirectory(includeDirectory);

            var cApi = cApiTranslator.TranslateFunctions(originalFunctions);
            writer.Write(code, cApi);
            File.WriteAllText(cApiOutputFile, code.ToString());

            Console.WriteLine("Done");
            Console.ReadKey(true);
        }
    }
}

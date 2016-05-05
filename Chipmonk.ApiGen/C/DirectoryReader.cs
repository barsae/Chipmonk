using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chipmonk.ApiGen.C {
    public class DirectoryReader {
        public IEnumerable<string> ReadAllLines(string directory, Regex filter) {
            foreach (var file in Directory.GetFiles(directory)) {
                foreach (var line in File.ReadAllLines(file)) {
                    var match = filter.Match(line);

                    if (match.Success) {
                        yield return line;
                    }
                }
            }
        }
    }
}

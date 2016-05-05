using System.Collections.Generic;
using Chipmonk.ApiGen.Models;

namespace Chipmonk.ApiGen.Models {
    public class Function {
        public string OriginalLine { get; set; }
        public string Name { get; set; }
        public string ReturnType { get; set; }
        public List<Parameter> Parameters { get; set; }
    }
}

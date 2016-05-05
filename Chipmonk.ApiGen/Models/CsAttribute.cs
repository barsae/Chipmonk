using System.Collections.Generic;

namespace Chipmonk.ApiGen.Models {
    public class CsAttribute {
        public string Name { get; set; }
        public List<string> Arguments { get; set; }
        public List<NamedArgument> NamedArguments { get; set; }
    }
}
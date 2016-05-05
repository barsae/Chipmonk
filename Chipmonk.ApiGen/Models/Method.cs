using System.Collections.Generic;

namespace Chipmonk.ApiGen.Models {
    public class Method {
        public List<CsAttribute> Attributes { get; set; }
        public string ReturnType { get; set; }
        public string Name { get; set; }
        public List<Argument> Arguments { get; set; }

        public bool Static { get; set; }
        public bool Extern { get; set; }
    }
}

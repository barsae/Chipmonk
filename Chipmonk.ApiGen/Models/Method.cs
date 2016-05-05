using System.Collections.Generic;

namespace Chipmonk.ApiGen.Models {
    public class Method {
        public List<string> Comments { get; set; }
        public List<CsAttribute> Attributes { get; set; }
        public string ReturnType { get; set; }
        public string Name { get; set; }
        public List<Parameter> Parameters { get; set; }
        public List<Expression> Body { get; set; }
        public bool Static { get; set; }
        public bool Extern { get; set; }
    }
}

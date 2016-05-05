using System.Collections.Generic;

namespace Chipmonk.ApiGen.Models {
    public class Constructor {
        public List<Parameter> Parameters { get; set; }
        public Expression Base { get; set; }
        public List<Expression> Body { get; set; }
    }
}

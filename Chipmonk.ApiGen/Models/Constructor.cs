using System.Collections.Generic;

namespace Chipmonk.ApiGen.Models {
    public class Constructor {
        public List<Argument> Arguments { get; set; }
        public List<Expression> Body { get; set; }
    }
}

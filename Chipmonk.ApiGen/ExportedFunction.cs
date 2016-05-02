using System.Collections.Generic;

namespace Chipmonk.ApiGen {
    public class ExportedFunction {
        public string FunctionName { get; set; }
        public string ReturnType { get; set; }
        public List<Argument> Arguments { get; set; }
    }
}

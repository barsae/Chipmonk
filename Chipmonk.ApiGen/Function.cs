﻿using System.Collections.Generic;

namespace Chipmonk.ApiGen {
    public class Function {
        public string OriginalLine { get; set; }
        public string FunctionName { get; set; }
        public string ReturnType { get; set; }
        public List<Argument> Arguments { get; set; }
    }
}

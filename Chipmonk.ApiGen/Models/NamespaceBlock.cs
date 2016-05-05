using System.Collections.Generic;

namespace Chipmonk.ApiGen.Models {
    public class NamespaceBlock {
        public string Namespace { get; set; }
        public List<Class> Classes { get; set; }
    }
}

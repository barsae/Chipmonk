using System.Collections.Generic;

namespace Chipmonk.ApiGen.Models {
    public class CsDirectory {
        public string Name { get; set; }
        public List<CsFile> Files { get; set; }
    }
}

using System.Collections.Generic;

namespace Chipmonk.ApiGen.Models {
    public class CsFile {
        public string Name { get; set; }
        public List<UsingStatement> UsingStatements { get; set; }
        public List<NamespaceBlock> NamespaceBlocks { get; set; }
        public List<Class> Classes { get; set; }
    }
}

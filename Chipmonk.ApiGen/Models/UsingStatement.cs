
namespace Chipmonk.ApiGen.Models {
    public class UsingStatement {
        public string Directive { get; set; }

        public UsingStatement(string directive) {
            this.Directive = directive;
        }
    }
}

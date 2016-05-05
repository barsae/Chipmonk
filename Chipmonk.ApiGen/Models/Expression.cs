
namespace Chipmonk.ApiGen.Models {
    public class Expression {
        public string Statement { get; set; }

        public Expression(string format, params object[] args) {
            Statement = string.Format(format, args);
        }
    }
}


namespace Chipmonk.ApiGen.Models {
    public class Parameter {
        public string Type { get; set; }
        public string Name { get; set; }

        public Parameter() {
        }

        public Parameter(string type, string name) {
            Type = type;
            Name = name;
        }
    }
}

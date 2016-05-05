
namespace Chipmonk.ApiGen.Models {
    public class NamedArgument {
        public string Name { get; set; }
        public string Value { get; set; }

        public NamedArgument(string name, string value ) {
            Name = name;
            Value = value;
        }
    }
}

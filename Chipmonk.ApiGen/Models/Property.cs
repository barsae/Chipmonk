
namespace Chipmonk.ApiGen.Models {
    public class Property {
        public string Type { get; set; }
        public string Name { get; set; }

        public Property(string type, string name) {
            Type = type;
            Name = name;
        }
    }
}

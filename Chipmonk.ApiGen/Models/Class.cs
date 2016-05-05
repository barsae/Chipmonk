using System.Collections.Generic;

namespace Chipmonk.ApiGen.Models {
    public class Class {
        public string Name { get; set; }
        public Class Parent { get; set; }
        public List<Property> Properties { get; set; }
        public List<Constructor> Constructors { get; set; }
        public List<Method> Methods { get; set; }
        public bool Static { get; set; }
    }
}

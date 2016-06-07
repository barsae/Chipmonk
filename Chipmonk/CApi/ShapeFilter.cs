using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.CApi {
    public struct ShapeFilter {
        public uint Group;
        public uint Categories;
        public uint Mask;

        public static ShapeFilter All = new ShapeFilter() {
            Group = ~((uint)0),
            Categories = ~((uint)0),
            Mask = ~((uint)0)
        };
    }
}

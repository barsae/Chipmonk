using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class BoxShape : Shape {
        public BoxShape(double width, double height, double radius) {
            Handle = CP.BoxShapeNew(Handle, width, height, radius);
        }

        public BoxShape(BB box, double radius) {
            Handle = CP.BoxShapeNew2(Handle, box, radius);
        }
    }
}

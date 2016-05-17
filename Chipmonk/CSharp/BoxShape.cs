using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class BoxShape : Shape {
        public BoxShape(Body body, double width, double height, double radius) {
            Handle = CP.BoxShapeNew(body.Handle, width, height, radius);
        }

        public BoxShape(Body body, BB box, double radius) {
            Handle = CP.BoxShapeNew2(body.Handle, box, radius);
        }
    }
}

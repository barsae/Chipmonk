using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class CircleShape : Shape {
        #region Properties
        public Vect Offset {
            get {
                return CP.CircleShapeGetOffset(Handle);
            }
            set {
                CP.CircleShapeSetOffset(Handle, value);
            }
        }

        public double Radius {
            get {
                return CP.CircleShapeGetRadius(Handle);
            }
            set {
                CP.CircleShapeSetRadius(Handle, value);
            }
        }
        #endregion Properties

        public CircleShape(Body body, double radius, Vect offset) {
            Handle = CP.CircleShapeNew(body.Handle, radius, offset);
        }
    }
}

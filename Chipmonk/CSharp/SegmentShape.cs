using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class SegmentShape : Shape {
        public Vect A {
            get {
                return _a;
            }
            set {
                _a = value;
                CP.SegmentShapeSetEndpoints(Handle, _a, _b);
            }
        }
        private Vect _a;

        public Vect B {
            get {
                return _b;
            }
            set {
                CP.SegmentShapeSetEndpoints(Handle, _a, _b);
            }
        }
        private Vect _b;

        public Vect Normal {
            get {
                return CP.SegmentShapeGetNormal(Handle);
            }
        }

        public double Radius {
            get {
                return CP.SegmentShapeGetRadius(Handle);
            }
            set {
                CP.SegmentShapeSetRadius(Handle, value);
            }
        }

        public SegmentShape(Body body, Vect a, Vect b, double radius) {
            _a = a;
            _b = b;
            Handle = CP.SegmentShapeNew(body.Handle, a, b, radius);
        }

        public void SetNeighbors(Vect prev, Vect next) {
            CP.SegmentShapeSetNeighbors(Handle, prev, next);
        }
    }
}

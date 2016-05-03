using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class CircleShape {
        public IntPtr shape { get; set; }

        public CircleShape(IntPtr body, double radius, Vect offset) {
            shape = CP.CircleShapeNew(body, radius, offset);
        }

        // CP_EXPORT cpVect cpCircleShapeGetOffset(const cpShape *shape);
        public Vect GetOffset() {
            return CP.CircleShapeGetOffset(shape);
        }

        // CP_EXPORT cpFloat cpCircleShapeGetRadius(const cpShape *shape);
        public double GetRadius() {
            return CP.CircleShapeGetRadius(shape);
        }

        // CP_EXPORT void cpCircleShapeSetOffset(cpShape *shape, cpVect offset);
        public void SetOffset(Vect offset) {
            CP.CircleShapeSetOffset(shape, offset);
        }

        // CP_EXPORT void cpCircleShapeSetRadius(cpShape *shape, cpFloat radius);
        public void SetRadius(double radius) {
            CP.CircleShapeSetRadius(shape, radius);
        }

    }
}

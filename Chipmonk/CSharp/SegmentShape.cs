using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class SegmentShape {
        public IntPtr shape { get; private set; }

        public SegmentShape(IntPtr body, Vect a, Vect b, double radius) {
            shape = CP.SegmentShapeNew(body, a, b, radius);
        }

        // CP_EXPORT cpVect cpSegmentShapeGetA(const cpShape *shape);
        public Vect GetA() {
            return CP.SegmentShapeGetA(shape);
        }

        // CP_EXPORT cpVect cpSegmentShapeGetB(const cpShape *shape);
        public Vect GetB() {
            return CP.SegmentShapeGetB(shape);
        }

        // CP_EXPORT cpVect cpSegmentShapeGetNormal(const cpShape *shape);
        public Vect GetNormal() {
            return CP.SegmentShapeGetNormal(shape);
        }

        // CP_EXPORT cpFloat cpSegmentShapeGetRadius(const cpShape *shape);
        public double GetRadius() {
            return CP.SegmentShapeGetRadius(shape);
        }

        // CP_EXPORT void cpSegmentShapeSetEndpoints(cpShape *shape, cpVect a, cpVect b);
        public void SetEndpoints(Vect a, Vect b) {
            CP.SegmentShapeSetEndpoints(shape, a, b);
        }

        // CP_EXPORT void cpSegmentShapeSetNeighbors(cpShape *shape, cpVect prev, cpVect next);
        public void SetNeighbors(Vect prev, Vect next) {
            CP.SegmentShapeSetNeighbors(shape, prev, next);
        }

        // CP_EXPORT void cpSegmentShapeSetRadius(cpShape *shape, cpFloat radius);
        public void SetRadius(double radius) {
            CP.SegmentShapeSetRadius(shape, radius);
        }

    }
}

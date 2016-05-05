using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PolyShape {
        public IntPtr shape { get; set; }

        public PolyShape(IntPtr body, int count, IntPtr verts, double radius) {
            shape = CP.PolyShapeNewRaw(body, count, verts, radius);
        }

        // CP_EXPORT int cpPolyShapeGetCount(const cpShape *shape);
        public int GetCount() {
            return CP.PolyShapeGetCount(shape);
        }

        // CP_EXPORT cpFloat cpPolyShapeGetRadius(const cpShape *shape);
        public double GetRadius() {
            return CP.PolyShapeGetRadius(shape);
        }

        // CP_EXPORT cpVect cpPolyShapeGetVert(const cpShape *shape, int index);
        public Vect GetVert(int index) {
            return CP.PolyShapeGetVert(shape, index);
        }

        // CP_EXPORT void cpPolyShapeSetRadius(cpShape *shape, cpFloat radius);
        public void SetRadius(double radius) {
            CP.PolyShapeSetRadius(shape, radius);
        }

        // CP_EXPORT void cpPolyShapeSetVertsRaw(cpShape *shape, int count, cpVect *verts);
        public void SetVertsRaw(int count, IntPtr verts) {
            CP.PolyShapeSetVertsRaw(shape, count, verts);
        }

    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PolyShape {
        public IntPtr poly { get; set; }

        public PolyShape(IntPtr body, int count, IntPtr verts, double radius) {
            poly = CP.PolyShapeNewRaw(body, count, verts, radius);
        }

        // CP_EXPORT int cpPolyShapeGetCount(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGetCount")]
        public static extern int GetCount(IntPtr shape);

        // CP_EXPORT cpFloat cpPolyShapeGetRadius(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGetRadius")]
        public static extern double GetRadius(IntPtr shape);

        // CP_EXPORT cpVect cpPolyShapeGetVert(const cpShape *shape, int index);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGetVert")]
        public static extern Vect GetVert(IntPtr shape, int index);

        // CP_EXPORT cpPolyShape* cpPolyShapeInitRaw(cpPolyShape *poly, cpBody *body, int count, const cpVect *verts, cpFloat radius);
        public IntPtr InitRaw(IntPtr body, int count, IntPtr verts, double radius) {
            return CP.PolyShapeInitRaw(poly, body, count, verts, radius);
        }

        // CP_EXPORT cpShape* cpPolyShapeNewRaw(cpBody *body, int count, const cpVect *verts, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpNewRaw")]
        public static extern IntPtr NewRaw(IntPtr body, int count, IntPtr verts, double radius);

        // CP_EXPORT void cpPolyShapeSetRadius(cpShape *shape, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSetRadius")]
        public static extern void SetRadius(IntPtr shape, double radius);

        // CP_EXPORT void cpPolyShapeSetVertsRaw(cpShape *shape, int count, cpVect *verts);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSetVertsRaw")]
        public static extern void SetVertsRaw(IntPtr shape, int count, IntPtr verts);

    }
}

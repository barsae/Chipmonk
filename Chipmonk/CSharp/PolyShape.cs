using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PolyShape : Shape {
        public PolyShape(Body body, int count, IntPtr verts, double radius) : base(CP.PolyShapeNewRaw(body.Handle, count, verts, radius)) {
        }

        public PolyShape(IntPtr handle) : base(handle) {
        }

        public static PolyShape Alloc() {
            return new PolyShape(CP.PolyShapeAlloc());
        }

        public PolyShape BoxShapeInit(Body body, double width, double height, double radius) {
            return new PolyShape(CP.BoxShapeInit(Handle, body.Handle, width, height, radius));
        }

        public PolyShape BoxShapeInit2(Body body, BB box, double radius) {
            return new PolyShape(CP.BoxShapeInit2(Handle, body.Handle, box, radius));
        }

        public int GetCount() {
            return CP.PolyShapeGetCount(Handle);
        }

        public double GetRadius() {
            return CP.PolyShapeGetRadius(Handle);
        }

        public Vect GetVert(int index) {
            return CP.PolyShapeGetVert(Handle, index);
        }

        public PolyShape InitRaw(Body body, int count, IntPtr verts, double radius) {
            return new PolyShape(CP.PolyShapeInitRaw(Handle, body.Handle, count, verts, radius));
        }

        public static Shape NewRaw(Body body, int count, IntPtr verts, double radius) {
            return new Shape(CP.PolyShapeNewRaw(body.Handle, count, verts, radius));
        }

        public void SetRadius(double radius) {
            CP.PolyShapeSetRadius(Handle, radius);
        }

        public void SetVertsRaw(int count, IntPtr verts) {
            CP.PolyShapeSetVertsRaw(Handle, count, verts);
        }

    }
}

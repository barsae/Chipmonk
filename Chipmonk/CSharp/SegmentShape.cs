using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class SegmentShape : Shape {
        public SegmentShape(Body body, Vect a, Vect b, double radius) : base(CP.SegmentShapeNew(body.Handle, a, b, radius)) {
        }

        public SegmentShape(IntPtr handle) : base(handle) {
        }

        public static SegmentShape Alloc() {
            return new SegmentShape(CP.SegmentShapeAlloc());
        }

        public Vect GetA() {
            return CP.SegmentShapeGetA(Handle);
        }

        public Vect GetB() {
            return CP.SegmentShapeGetB(Handle);
        }

        public Vect GetNormal() {
            return CP.SegmentShapeGetNormal(Handle);
        }

        public double GetRadius() {
            return CP.SegmentShapeGetRadius(Handle);
        }

        public SegmentShape Init(Body body, Vect a, Vect b, double radius) {
            return new SegmentShape(CP.SegmentShapeInit(Handle, body.Handle, a, b, radius));
        }

        public static Shape New(Body body, Vect a, Vect b, double radius) {
            return new Shape(CP.SegmentShapeNew(body.Handle, a, b, radius));
        }

        public void SetEndpoints(Vect a, Vect b) {
            CP.SegmentShapeSetEndpoints(Handle, a, b);
        }

        public void SetNeighbors(Vect prev, Vect next) {
            CP.SegmentShapeSetNeighbors(Handle, prev, next);
        }

        public void SetRadius(double radius) {
            CP.SegmentShapeSetRadius(Handle, radius);
        }

    }
}

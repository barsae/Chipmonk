using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class CircleShape : Shape {
        public CircleShape(Body body, double radius, Vect offset) : base(CP.CircleShapeNew(body.Handle, radius, offset)) {
        }

        public CircleShape(IntPtr handle) : base(handle) {
        }

        public static CircleShape Alloc() {
            return new CircleShape(CP.CircleShapeAlloc());
        }

        public Vect GetOffset() {
            return CP.CircleShapeGetOffset(Handle);
        }

        public double GetRadius() {
            return CP.CircleShapeGetRadius(Handle);
        }

        public CircleShape Init(Body body, double radius, Vect offset) {
            return new CircleShape(CP.CircleShapeInit(Handle, body.Handle, radius, offset));
        }

        public static Shape New(Body body, double radius, Vect offset) {
            return new Shape(CP.CircleShapeNew(body.Handle, radius, offset));
        }

        public void SetOffset(Vect offset) {
            CP.CircleShapeSetOffset(Handle, offset);
        }

        public void SetRadius(double radius) {
            CP.CircleShapeSetRadius(Handle, radius);
        }

    }
}

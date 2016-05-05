using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Shape {
        public IntPtr Handle { get; set; }

        public Shape(IntPtr handle) {
            Handle = handle;
        }

        public BB CacheBB() {
            return CP.ShapeCacheBB(Handle);
        }

        public void Destroy() {
            CP.ShapeDestroy(Handle);
        }

        public void Free() {
            CP.ShapeFree(Handle);
        }

        public double GetArea() {
            return CP.ShapeGetArea(Handle);
        }

        public BB GetBB() {
            return CP.ShapeGetBB(Handle);
        }

        public Body GetBody() {
            return new Body(CP.ShapeGetBody(Handle));
        }

        public Vect GetCenterOfGravity() {
            return CP.ShapeGetCenterOfGravity(Handle);
        }

        public double GetDensity() {
            return CP.ShapeGetDensity(Handle);
        }

        public double GetElasticity() {
            return CP.ShapeGetElasticity(Handle);
        }

        public double GetFriction() {
            return CP.ShapeGetFriction(Handle);
        }

        public double GetMass() {
            return CP.ShapeGetMass(Handle);
        }

        public double GetMoment() {
            return CP.ShapeGetMoment(Handle);
        }

        public bool GetSensor() {
            return CP.ShapeGetSensor(Handle);
        }

        public Space GetSpace() {
            return new Space(CP.ShapeGetSpace(Handle));
        }

        public Vect GetSurfaceVelocity() {
            return CP.ShapeGetSurfaceVelocity(Handle);
        }

        public IntPtr GetUserData() {
            return CP.ShapeGetUserData(Handle);
        }

        public double PointQuery(Vect p, IntPtr output) {
            return CP.ShapePointQuery(Handle, p, output);
        }

        public bool SegmentQuery(Vect a, Vect b, double radius, IntPtr info) {
            return CP.ShapeSegmentQuery(Handle, a, b, radius, info);
        }

        public void SetBody(Body body) {
            CP.ShapeSetBody(Handle, body.Handle);
        }

        public void SetDensity(double density) {
            CP.ShapeSetDensity(Handle, density);
        }

        public void SetElasticity(double elasticity) {
            CP.ShapeSetElasticity(Handle, elasticity);
        }

        public void SetFriction(double friction) {
            CP.ShapeSetFriction(Handle, friction);
        }

        public void SetMass(double mass) {
            CP.ShapeSetMass(Handle, mass);
        }

        public void SetSensor(bool sensor) {
            CP.ShapeSetSensor(Handle, sensor);
        }

        public void SetSurfaceVelocity(Vect surfaceVelocity) {
            CP.ShapeSetSurfaceVelocity(Handle, surfaceVelocity);
        }

        public void SetUserData(IntPtr userData) {
            CP.ShapeSetUserData(Handle, userData);
        }

    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Shape {
        public IntPtr shape { get; set; }

        // CP_EXPORT cpBB cpShapeCacheBB(cpShape *shape);
        public BB CacheBB() {
            return CP.ShapeCacheBB(shape);
        }

        // CP_EXPORT cpFloat cpShapeGetArea(cpShape *shape);
        public double GetArea() {
            return CP.ShapeGetArea(shape);
        }

        // CP_EXPORT cpBB cpShapeGetBB(const cpShape *shape);
        public BB GetBB() {
            return CP.ShapeGetBB(shape);
        }

        // CP_EXPORT cpBody* cpShapeGetBody(const cpShape *shape);
        public IntPtr GetBody() {
            return CP.ShapeGetBody(shape);
        }

        // CP_EXPORT cpVect cpShapeGetCenterOfGravity(cpShape *shape);
        public Vect GetCenterOfGravity() {
            return CP.ShapeGetCenterOfGravity(shape);
        }

        // CP_EXPORT cpFloat cpShapeGetDensity(cpShape *shape);
        public double GetDensity() {
            return CP.ShapeGetDensity(shape);
        }

        // CP_EXPORT cpFloat cpShapeGetElasticity(const cpShape *shape);
        public double GetElasticity() {
            return CP.ShapeGetElasticity(shape);
        }

        // CP_EXPORT cpFloat cpShapeGetFriction(const cpShape *shape);
        public double GetFriction() {
            return CP.ShapeGetFriction(shape);
        }

        // CP_EXPORT cpFloat cpShapeGetMass(cpShape *shape);
        public double GetMass() {
            return CP.ShapeGetMass(shape);
        }

        // CP_EXPORT cpFloat cpShapeGetMoment(cpShape *shape);
        public double GetMoment() {
            return CP.ShapeGetMoment(shape);
        }

        // CP_EXPORT cpBool cpShapeGetSensor(const cpShape *shape);
        public bool GetSensor() {
            return CP.ShapeGetSensor(shape);
        }

        // CP_EXPORT cpSpace* cpShapeGetSpace(const cpShape *shape);
        public IntPtr GetSpace() {
            return CP.ShapeGetSpace(shape);
        }

        // CP_EXPORT cpVect cpShapeGetSurfaceVelocity(const cpShape *shape);
        public Vect GetSurfaceVelocity() {
            return CP.ShapeGetSurfaceVelocity(shape);
        }

        // CP_EXPORT cpDataPointer cpShapeGetUserData(const cpShape *shape);
        public IntPtr GetUserData() {
            return CP.ShapeGetUserData(shape);
        }

        // CP_EXPORT cpFloat cpShapePointQuery(const cpShape *shape, cpVect p, cpPointQueryInfo *out);
        public double PointQuery(Vect p, IntPtr output) {
            return CP.ShapePointQuery(shape, p, output);
        }

        // CP_EXPORT cpBool cpShapeSegmentQuery(const cpShape *shape, cpVect a, cpVect b, cpFloat radius, cpSegmentQueryInfo *info);
        public bool SegmentQuery(Vect a, Vect b, double radius, IntPtr info) {
            return CP.ShapeSegmentQuery(shape, a, b, radius, info);
        }

        // CP_EXPORT void cpShapeSetBody(cpShape *shape, cpBody *body);
        public void SetBody(IntPtr body) {
            CP.ShapeSetBody(shape, body);
        }

        // CP_EXPORT void cpShapeSetDensity(cpShape *shape, cpFloat density);
        public void SetDensity(double density) {
            CP.ShapeSetDensity(shape, density);
        }

        // CP_EXPORT void cpShapeSetElasticity(cpShape *shape, cpFloat elasticity);
        public void SetElasticity(double elasticity) {
            CP.ShapeSetElasticity(shape, elasticity);
        }

        // CP_EXPORT void cpShapeSetFriction(cpShape *shape, cpFloat friction);
        public void SetFriction(double friction) {
            CP.ShapeSetFriction(shape, friction);
        }

        // CP_EXPORT void cpShapeSetMass(cpShape *shape, cpFloat mass);
        public void SetMass(double mass) {
            CP.ShapeSetMass(shape, mass);
        }

        // CP_EXPORT void cpShapeSetSensor(cpShape *shape, cpBool sensor);
        public void SetSensor(bool sensor) {
            CP.ShapeSetSensor(shape, sensor);
        }

        // CP_EXPORT void cpShapeSetSurfaceVelocity(cpShape *shape, cpVect surfaceVelocity);
        public void SetSurfaceVelocity(Vect surfaceVelocity) {
            CP.ShapeSetSurfaceVelocity(shape, surfaceVelocity);
        }

        // CP_EXPORT void cpShapeSetUserData(cpShape *shape, cpDataPointer userData);
        public void SetUserData(IntPtr userData) {
            CP.ShapeSetUserData(shape, userData);
        }

    }
}

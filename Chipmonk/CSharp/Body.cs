using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Body {
        public IntPtr Handle { get; set; }

        public Body(double mass, double moment) {
            Handle = CP.BodyNew(mass, moment);
        }

        public Body(IntPtr handle) {
            Handle = handle;
        }

        public void Activate() {
            CP.BodyActivate(Handle);
        }

        public void ActivateStatic(Shape filter) {
            CP.BodyActivateStatic(Handle, filter.Handle);
        }

        public static Body Alloc() {
            return new Body(CP.BodyAlloc());
        }

        public void ApplyForceAtLocalPoint(Vect force, Vect point) {
            CP.BodyApplyForceAtLocalPoint(Handle, force, point);
        }

        public void ApplyForceAtWorldPoint(Vect force, Vect point) {
            CP.BodyApplyForceAtWorldPoint(Handle, force, point);
        }

        public void ApplyImpulseAtLocalPoint(Vect impulse, Vect point) {
            CP.BodyApplyImpulseAtLocalPoint(Handle, impulse, point);
        }

        public void ApplyImpulseAtWorldPoint(Vect impulse, Vect point) {
            CP.BodyApplyImpulseAtWorldPoint(Handle, impulse, point);
        }

        public Shape BoxShapeNew(double width, double height, double radius) {
            return new Shape(CP.BoxShapeNew(Handle, width, height, radius));
        }

        public Shape BoxShapeNew2(BB box, double radius) {
            return new Shape(CP.BoxShapeNew2(Handle, box, radius));
        }

        public void Destroy() {
            CP.BodyDestroy(Handle);
        }

        public void Free() {
            CP.BodyFree(Handle);
        }

        public double GetAngle() {
            return CP.BodyGetAngle(Handle);
        }

        public double GetAngularVelocity() {
            return CP.BodyGetAngularVelocity(Handle);
        }

        public Vect GetCenterOfGravity() {
            return CP.BodyGetCenterOfGravity(Handle);
        }

        public Vect GetForce() {
            return CP.BodyGetForce(Handle);
        }

        public double GetMass() {
            return CP.BodyGetMass(Handle);
        }

        public double GetMoment() {
            return CP.BodyGetMoment(Handle);
        }

        public Vect GetPosition() {
            return CP.BodyGetPosition(Handle);
        }

        public Vect GetRotation() {
            return CP.BodyGetRotation(Handle);
        }

        public Space GetSpace() {
            return new Space(CP.BodyGetSpace(Handle));
        }

        public double GetTorque() {
            return CP.BodyGetTorque(Handle);
        }

        public BodyType GetType() {
            return CP.BodyGetType(Handle);
        }

        public IntPtr GetUserData() {
            return CP.BodyGetUserData(Handle);
        }

        public Vect GetVelocity() {
            return CP.BodyGetVelocity(Handle);
        }

        public Vect GetVelocityAtLocalPoint(Vect point) {
            return CP.BodyGetVelocityAtLocalPoint(Handle, point);
        }

        public Vect GetVelocityAtWorldPoint(Vect point) {
            return CP.BodyGetVelocityAtWorldPoint(Handle, point);
        }

        public Body Init(double mass, double moment) {
            return new Body(CP.BodyInit(Handle, mass, moment));
        }

        public bool IsSleeping() {
            return CP.BodyIsSleeping(Handle);
        }

        public double KineticEnergy() {
            return CP.BodyKineticEnergy(Handle);
        }

        public Vect LocalToWorld(Vect point) {
            return CP.BodyLocalToWorld(Handle, point);
        }

        public static Body New(double mass, double moment) {
            return new Body(CP.BodyNew(mass, moment));
        }

        public static Body NewKinematic() {
            return new Body(CP.BodyNewKinematic());
        }

        public static Body NewStatic() {
            return new Body(CP.BodyNewStatic());
        }

        public void SetAngle(double a) {
            CP.BodySetAngle(Handle, a);
        }

        public void SetAngularVelocity(double angularVelocity) {
            CP.BodySetAngularVelocity(Handle, angularVelocity);
        }

        public void SetCenterOfGravity(Vect cog) {
            CP.BodySetCenterOfGravity(Handle, cog);
        }

        public void SetForce(Vect force) {
            CP.BodySetForce(Handle, force);
        }

        public void SetMass(double m) {
            CP.BodySetMass(Handle, m);
        }

        public void SetMoment(double i) {
            CP.BodySetMoment(Handle, i);
        }

        public void SetPosition(Vect pos) {
            CP.BodySetPosition(Handle, pos);
        }

        public void SetTorque(double torque) {
            CP.BodySetTorque(Handle, torque);
        }

        public void SetType(BodyType type) {
            CP.BodySetType(Handle, type);
        }

        public void SetUserData(IntPtr userData) {
            CP.BodySetUserData(Handle, userData);
        }

        public void SetVelocity(Vect velocity) {
            CP.BodySetVelocity(Handle, velocity);
        }

        public void Sleep() {
            CP.BodySleep(Handle);
        }

        public void SleepWithGroup(Body group) {
            CP.BodySleepWithGroup(Handle, group.Handle);
        }

        public void UpdatePosition(double dt) {
            CP.BodyUpdatePosition(Handle, dt);
        }

        public void UpdateVelocity(Vect gravity, double damping, double dt) {
            CP.BodyUpdateVelocity(Handle, gravity, damping, dt);
        }

        public Vect WorldToLocal(Vect point) {
            return CP.BodyWorldToLocal(Handle, point);
        }

    }
}

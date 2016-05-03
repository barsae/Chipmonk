using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Body {
        public IntPtr body { get; private set; }

        public Body(double mass, double moment) {
            body = CP.BodyNew(mass, moment);
        }

        // CP_EXPORT void cpBodyActivate(cpBody *body);
        public void Activate() {
            CP.BodyActivate(body);
        }

        // CP_EXPORT void cpBodyActivateStatic(cpBody *body, cpShape *filter);
        public void ActivateStatic(IntPtr filter) {
            CP.BodyActivateStatic(body, filter);
        }

        // CP_EXPORT void cpBodyApplyForceAtLocalPoint(cpBody *body, cpVect force, cpVect point);
        public void ApplyForceAtLocalPoint(Vect force, Vect point) {
            CP.BodyApplyForceAtLocalPoint(body, force, point);
        }

        // CP_EXPORT void cpBodyApplyForceAtWorldPoint(cpBody *body, cpVect force, cpVect point);
        public void ApplyForceAtWorldPoint(Vect force, Vect point) {
            CP.BodyApplyForceAtWorldPoint(body, force, point);
        }

        // CP_EXPORT void cpBodyApplyImpulseAtLocalPoint(cpBody *body, cpVect impulse, cpVect point);
        public void ApplyImpulseAtLocalPoint(Vect impulse, Vect point) {
            CP.BodyApplyImpulseAtLocalPoint(body, impulse, point);
        }

        // CP_EXPORT void cpBodyApplyImpulseAtWorldPoint(cpBody *body, cpVect impulse, cpVect point);
        public void ApplyImpulseAtWorldPoint(Vect impulse, Vect point) {
            CP.BodyApplyImpulseAtWorldPoint(body, impulse, point);
        }

        // CP_EXPORT cpFloat cpBodyGetAngle(const cpBody *body);
        public double GetAngle() {
            return CP.BodyGetAngle(body);
        }

        // CP_EXPORT cpFloat cpBodyGetAngularVelocity(const cpBody *body);
        public double GetAngularVelocity() {
            return CP.BodyGetAngularVelocity(body);
        }

        // CP_EXPORT cpVect cpBodyGetCenterOfGravity(const cpBody *body);
        public Vect GetCenterOfGravity() {
            return CP.BodyGetCenterOfGravity(body);
        }

        // CP_EXPORT cpVect cpBodyGetForce(const cpBody *body);
        public Vect GetForce() {
            return CP.BodyGetForce(body);
        }

        // CP_EXPORT cpFloat cpBodyGetMass(const cpBody *body);
        public double GetMass() {
            return CP.BodyGetMass(body);
        }

        // CP_EXPORT cpFloat cpBodyGetMoment(const cpBody *body);
        public double GetMoment() {
            return CP.BodyGetMoment(body);
        }

        // CP_EXPORT cpVect cpBodyGetPosition(const cpBody *body);
        public Vect GetPosition() {
            return CP.BodyGetPosition(body);
        }

        // CP_EXPORT cpVect cpBodyGetRotation(const cpBody *body);
        public Vect GetRotation() {
            return CP.BodyGetRotation(body);
        }

        // CP_EXPORT cpSpace* cpBodyGetSpace(const cpBody *body);
        public IntPtr GetSpace() {
            return CP.BodyGetSpace(body);
        }

        // CP_EXPORT cpFloat cpBodyGetTorque(const cpBody *body);
        public double GetTorque() {
            return CP.BodyGetTorque(body);
        }

        // CP_EXPORT cpBodyType cpBodyGetType(cpBody *body);
        public BodyType GetType() {
            return CP.BodyGetType(body);
        }

        // CP_EXPORT cpDataPointer cpBodyGetUserData(const cpBody *body);
        public IntPtr GetUserData() {
            return CP.BodyGetUserData(body);
        }

        // CP_EXPORT cpVect cpBodyGetVelocity(const cpBody *body);
        public Vect GetVelocity() {
            return CP.BodyGetVelocity(body);
        }

        // CP_EXPORT cpVect cpBodyGetVelocityAtLocalPoint(const cpBody *body, cpVect point);
        public Vect GetVelocityAtLocalPoint(Vect point) {
            return CP.BodyGetVelocityAtLocalPoint(body, point);
        }

        // CP_EXPORT cpVect cpBodyGetVelocityAtWorldPoint(const cpBody *body, cpVect point);
        public Vect GetVelocityAtWorldPoint(Vect point) {
            return CP.BodyGetVelocityAtWorldPoint(body, point);
        }

        // CP_EXPORT cpBool cpBodyIsSleeping(const cpBody *body);
        public bool IsSleeping() {
            return CP.BodyIsSleeping(body);
        }

        // CP_EXPORT cpFloat cpBodyKineticEnergy(const cpBody *body);
        public double KineticEnergy() {
            return CP.BodyKineticEnergy(body);
        }

        // CP_EXPORT cpVect cpBodyLocalToWorld(const cpBody *body, const cpVect point);
        public Vect LocalToWorld(Vect point) {
            return CP.BodyLocalToWorld(body, point);
        }

        // CP_EXPORT cpBody* cpBodyNewKinematic(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpNewKinematic")]
        public static extern Body NewKinematic();

        // CP_EXPORT cpBody* cpBodyNewStatic(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpNewStatic")]
        public static extern Body NewStatic();

        // CP_EXPORT void cpBodySetAngle(cpBody *body, cpFloat a);
        public void SetAngle(double a) {
            CP.BodySetAngle(body, a);
        }

        // CP_EXPORT void cpBodySetAngularVelocity(cpBody *body, cpFloat angularVelocity);
        public void SetAngularVelocity(double angularVelocity) {
            CP.BodySetAngularVelocity(body, angularVelocity);
        }

        // CP_EXPORT void cpBodySetCenterOfGravity(cpBody *body, cpVect cog);
        public void SetCenterOfGravity(Vect cog) {
            CP.BodySetCenterOfGravity(body, cog);
        }

        // CP_EXPORT void cpBodySetForce(cpBody *body, cpVect force);
        public void SetForce(Vect force) {
            CP.BodySetForce(body, force);
        }

        // CP_EXPORT void cpBodySetMass(cpBody *body, cpFloat m);
        public void SetMass(double m) {
            CP.BodySetMass(body, m);
        }

        // CP_EXPORT void cpBodySetMoment(cpBody *body, cpFloat i);
        public void SetMoment(double i) {
            CP.BodySetMoment(body, i);
        }

        // CP_EXPORT void cpBodySetPosition(cpBody *body, cpVect pos);
        public void SetPosition(Vect pos) {
            CP.BodySetPosition(body, pos);
        }

        // CP_EXPORT void cpBodySetTorque(cpBody *body, cpFloat torque);
        public void SetTorque(double torque) {
            CP.BodySetTorque(body, torque);
        }

        // CP_EXPORT void cpBodySetType(cpBody *body, cpBodyType type);
        public void SetType(BodyType type) {
            CP.BodySetType(body, type);
        }

        // CP_EXPORT void cpBodySetUserData(cpBody *body, cpDataPointer userData);
        public void SetUserData(IntPtr userData) {
            CP.BodySetUserData(body, userData);
        }

        // CP_EXPORT void cpBodySetVelocity(cpBody *body, cpVect velocity);
        public void SetVelocity(Vect velocity) {
            CP.BodySetVelocity(body, velocity);
        }

        // CP_EXPORT void cpBodySleep(cpBody *body);
        public void Sleep() {
            CP.BodySleep(body);
        }

        // CP_EXPORT void cpBodySleepWithGroup(cpBody *body, cpBody *group);
        public void SleepWithGroup(Body group) {
            CP.BodySleepWithGroup(body, group);
        }

        // CP_EXPORT void cpBodyUpdatePosition(cpBody *body, cpFloat dt);
        public void UpdatePosition(double dt) {
            CP.BodyUpdatePosition(body, dt);
        }

        // CP_EXPORT void cpBodyUpdateVelocity(cpBody *body, cpVect gravity, cpFloat damping, cpFloat dt);
        public void UpdateVelocity(Vect gravity, double damping, double dt) {
            CP.BodyUpdateVelocity(body, gravity, damping, dt);
        }

        // CP_EXPORT cpVect cpBodyWorldToLocal(const cpBody *body, const cpVect point);
        public Vect WorldToLocal(Vect point) {
            return CP.BodyWorldToLocal(body, point);
        }

    }
}

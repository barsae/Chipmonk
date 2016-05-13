using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Body : IDisposable {
        internal IntPtr Handle { get; private set; }

        #region Properties
        public double Angle {
            get {
                return CP.BodyGetAngle(Handle);
            }
            set {
                CP.BodySetAngle(Handle, value);
            }
        }

        public double AngularVelocity {
            get {
                return CP.BodyGetAngularVelocity(Handle);
            }
            set {
                CP.BodySetAngularVelocity(Handle, value);
            }
        }

        public Vect CenterOfGravity {
            get {
                return CP.BodyGetCenterOfGravity(Handle);
            }
            set {
                CP.BodySetCenterOfGravity(Handle, value);
            }
        }

        public Vect Force {
            get {
                return CP.BodyGetForce(Handle);
            }
            set {
                CP.BodySetForce(Handle, value);
            }
        }

        public bool IsSleeping {
            get {
                return CP.BodyIsSleeping(Handle);
            }
            set {
                CP.BodyIsSleeping(Handle);
            }
        }

        public double Mass {
            get {
                return CP.BodyGetMass(Handle);
            }
            set {
                CP.BodySetMass(Handle, value);
            }
        }

        public double Moment {
            get {
                return CP.BodyGetMoment(Handle);
            }
            set {
                CP.BodySetMoment(Handle, value);
            }
        }

        public Vect Position {
            get {
                return CP.BodyGetPosition(Handle);
            }
            set {
                CP.BodySetPosition(Handle, value);
            }
        }

        public Vect Rotation {
            get {
                return CP.BodyGetRotation(Handle);
            }
        }

        public Space Space {
            get {
                return new Space(CP.BodyGetSpace(Handle));
            }
        }

        public double Torque {
            get {
                return CP.BodyGetTorque(Handle);
            }
            set {
                CP.BodySetTorque(Handle, value);
            }
        }

        public BodyType Type {
            get {
                return CP.BodyGetType(Handle);
            }
            set {
                CP.BodySetType(Handle, value);
            }
        }

        public IntPtr UserData {
            get {
                return CP.BodyGetUserData(Handle);
            }
            set {
                CP.BodySetUserData(Handle, value);
            }
        }

        public Vect Velocity {
            get {
                return CP.BodyGetVelocity(Handle);
            }
            set {
                CP.BodySetVelocity(Handle, value);
            }
        }
        #endregion Properties

        public Body(double mass, double moment) {
            Handle = CP.BodyNew(mass, moment);
        }

        internal Body(IntPtr handle) {
            Handle = handle;
        }

        #region Methods

        #endregion Methods
        public void Activate() {
            CP.BodyActivate(Handle);
        }

        public void ActivateStatic(Shape filter) {
            CP.BodyActivateStatic(Handle, filter.Handle);
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

        public void Dispose() {
            CP.BodyFree(Handle);
        }

        public Vect GetVelocityAtLocalPoint(Vect point) {
            return CP.BodyGetVelocityAtLocalPoint(Handle, point);
        }

        public Vect GetVelocityAtWorldPoint(Vect point) {
            return CP.BodyGetVelocityAtWorldPoint(Handle, point);
        }

        public double KineticEnergy() {
            return CP.BodyKineticEnergy(Handle);
        }

        public Vect LocalToWorld(Vect point) {
            return CP.BodyLocalToWorld(Handle, point);
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

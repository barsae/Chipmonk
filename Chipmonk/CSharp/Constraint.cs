using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Constraint {
        public IntPtr Handle { get; set; }

        public Constraint(IntPtr handle) {
            Handle = handle;
        }

        public void Destroy() {
            CP.ConstraintDestroy(Handle);
        }

        public void Free() {
            CP.ConstraintFree(Handle);
        }

        public Body GetBodyA() {
            return new Body(CP.ConstraintGetBodyA(Handle));
        }

        public Body GetBodyB() {
            return new Body(CP.ConstraintGetBodyB(Handle));
        }

        public bool GetCollideBodies() {
            return CP.ConstraintGetCollideBodies(Handle);
        }

        public double GetErrorBias() {
            return CP.ConstraintGetErrorBias(Handle);
        }

        public double GetImpulse() {
            return CP.ConstraintGetImpulse(Handle);
        }

        public double GetMaxBias() {
            return CP.ConstraintGetMaxBias(Handle);
        }

        public double GetMaxForce() {
            return CP.ConstraintGetMaxForce(Handle);
        }

        public Space GetSpace() {
            return new Space(CP.ConstraintGetSpace(Handle));
        }

        public IntPtr GetUserData() {
            return CP.ConstraintGetUserData(Handle);
        }

        public bool IsDampedRotarySpring() {
            return CP.ConstraintIsDampedRotarySpring(Handle);
        }

        public bool IsDampedSpring() {
            return CP.ConstraintIsDampedSpring(Handle);
        }

        public bool IsGearJoint() {
            return CP.ConstraintIsGearJoint(Handle);
        }

        public bool IsGrooveJoint() {
            return CP.ConstraintIsGrooveJoint(Handle);
        }

        public bool IsPinJoint() {
            return CP.ConstraintIsPinJoint(Handle);
        }

        public bool IsPivotJoint() {
            return CP.ConstraintIsPivotJoint(Handle);
        }

        public bool IsRatchetJoint() {
            return CP.ConstraintIsRatchetJoint(Handle);
        }

        public bool IsRotaryLimitJoint() {
            return CP.ConstraintIsRotaryLimitJoint(Handle);
        }

        public bool IsSimpleMotor() {
            return CP.ConstraintIsSimpleMotor(Handle);
        }

        public bool IsSlideJoint() {
            return CP.ConstraintIsSlideJoint(Handle);
        }

        public void SetCollideBodies(bool collideBodies) {
            CP.ConstraintSetCollideBodies(Handle, collideBodies);
        }

        public void SetErrorBias(double errorBias) {
            CP.ConstraintSetErrorBias(Handle, errorBias);
        }

        public void SetMaxBias(double maxBias) {
            CP.ConstraintSetMaxBias(Handle, maxBias);
        }

        public void SetMaxForce(double maxForce) {
            CP.ConstraintSetMaxForce(Handle, maxForce);
        }

        public void SetUserData(IntPtr userData) {
            CP.ConstraintSetUserData(Handle, userData);
        }

    }
}

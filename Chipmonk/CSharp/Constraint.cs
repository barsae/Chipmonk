using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Constraint {
        public IntPtr constraint { get; private set; }

        // CP_EXPORT cpBody* cpConstraintGetBodyA(const cpConstraint *constraint);
        public Body GetBodyA() {
            return CP.ConstraintGetBodyA(constraint);
        }

        // CP_EXPORT cpBody* cpConstraintGetBodyB(const cpConstraint *constraint);
        public Body GetBodyB() {
            return CP.ConstraintGetBodyB(constraint);
        }

        // CP_EXPORT cpBool cpConstraintGetCollideBodies(const cpConstraint *constraint);
        public bool GetCollideBodies() {
            return CP.ConstraintGetCollideBodies(constraint);
        }

        // CP_EXPORT cpFloat cpConstraintGetErrorBias(const cpConstraint *constraint);
        public double GetErrorBias() {
            return CP.ConstraintGetErrorBias(constraint);
        }

        // CP_EXPORT cpFloat cpConstraintGetImpulse(cpConstraint *constraint);
        public double GetImpulse() {
            return CP.ConstraintGetImpulse(constraint);
        }

        // CP_EXPORT cpFloat cpConstraintGetMaxBias(const cpConstraint *constraint);
        public double GetMaxBias() {
            return CP.ConstraintGetMaxBias(constraint);
        }

        // CP_EXPORT cpFloat cpConstraintGetMaxForce(const cpConstraint *constraint);
        public double GetMaxForce() {
            return CP.ConstraintGetMaxForce(constraint);
        }

        // CP_EXPORT cpSpace* cpConstraintGetSpace(const cpConstraint *constraint);
        public IntPtr GetSpace() {
            return CP.ConstraintGetSpace(constraint);
        }

        // CP_EXPORT cpDataPointer cpConstraintGetUserData(const cpConstraint *constraint);
        public IntPtr GetUserData() {
            return CP.ConstraintGetUserData(constraint);
        }

        // CP_EXPORT cpBool cpConstraintIsDampedRotarySpring(const cpConstraint *constraint);
        public bool IsDampedRotarySpring() {
            return CP.ConstraintIsDampedRotarySpring(constraint);
        }

        // CP_EXPORT cpBool cpConstraintIsDampedSpring(const cpConstraint *constraint);
        public bool IsDampedSpring() {
            return CP.ConstraintIsDampedSpring(constraint);
        }

        // CP_EXPORT cpBool cpConstraintIsGearJoint(const cpConstraint *constraint);
        public bool IsGearJoint() {
            return CP.ConstraintIsGearJoint(constraint);
        }

        // CP_EXPORT cpBool cpConstraintIsGrooveJoint(const cpConstraint *constraint);
        public bool IsGrooveJoint() {
            return CP.ConstraintIsGrooveJoint(constraint);
        }

        // CP_EXPORT cpBool cpConstraintIsPinJoint(const cpConstraint *constraint);
        public bool IsPinJoint() {
            return CP.ConstraintIsPinJoint(constraint);
        }

        // CP_EXPORT cpBool cpConstraintIsPivotJoint(const cpConstraint *constraint);
        public bool IsPivotJoint() {
            return CP.ConstraintIsPivotJoint(constraint);
        }

        // CP_EXPORT cpBool cpConstraintIsRatchetJoint(const cpConstraint *constraint);
        public bool IsRatchetJoint() {
            return CP.ConstraintIsRatchetJoint(constraint);
        }

        // CP_EXPORT cpBool cpConstraintIsRotaryLimitJoint(const cpConstraint *constraint);
        public bool IsRotaryLimitJoint() {
            return CP.ConstraintIsRotaryLimitJoint(constraint);
        }

        // CP_EXPORT cpBool cpConstraintIsSimpleMotor(const cpConstraint *constraint);
        public bool IsSimpleMotor() {
            return CP.ConstraintIsSimpleMotor(constraint);
        }

        // CP_EXPORT cpBool cpConstraintIsSlideJoint(const cpConstraint *constraint);
        public bool IsSlideJoint() {
            return CP.ConstraintIsSlideJoint(constraint);
        }

        // CP_EXPORT void cpConstraintSetCollideBodies(cpConstraint *constraint, cpBool collideBodies);
        public void SetCollideBodies(bool collideBodies) {
            CP.ConstraintSetCollideBodies(constraint, collideBodies);
        }

        // CP_EXPORT void cpConstraintSetErrorBias(cpConstraint *constraint, cpFloat errorBias);
        public void SetErrorBias(double errorBias) {
            CP.ConstraintSetErrorBias(constraint, errorBias);
        }

        // CP_EXPORT void cpConstraintSetMaxBias(cpConstraint *constraint, cpFloat maxBias);
        public void SetMaxBias(double maxBias) {
            CP.ConstraintSetMaxBias(constraint, maxBias);
        }

        // CP_EXPORT void cpConstraintSetMaxForce(cpConstraint *constraint, cpFloat maxForce);
        public void SetMaxForce(double maxForce) {
            CP.ConstraintSetMaxForce(constraint, maxForce);
        }

        // CP_EXPORT void cpConstraintSetUserData(cpConstraint *constraint, cpDataPointer userData);
        public void SetUserData(IntPtr userData) {
            CP.ConstraintSetUserData(constraint, userData);
        }

    }
}

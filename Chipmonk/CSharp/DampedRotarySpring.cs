using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class DampedRotarySpring {
        public IntPtr constraint { get; private set; }

        public DampedRotarySpring(Body a, Body b, double restAngle, double stiffness, double damping) {
            constraint = CP.DampedRotarySpringNew(a, b, restAngle, stiffness, damping);
        }

        // CP_EXPORT cpFloat cpDampedRotarySpringGetDamping(const cpConstraint *constraint);
        public double GetDamping() {
            return CP.DampedRotarySpringGetDamping(constraint);
        }

        // CP_EXPORT cpFloat cpDampedRotarySpringGetRestAngle(const cpConstraint *constraint);
        public double GetRestAngle() {
            return CP.DampedRotarySpringGetRestAngle(constraint);
        }

        // CP_EXPORT cpFloat cpDampedRotarySpringGetStiffness(const cpConstraint *constraint);
        public double GetStiffness() {
            return CP.DampedRotarySpringGetStiffness(constraint);
        }

        // CP_EXPORT void cpDampedRotarySpringSetDamping(cpConstraint *constraint, cpFloat damping);
        public void SetDamping(double damping) {
            CP.DampedRotarySpringSetDamping(constraint, damping);
        }

        // CP_EXPORT void cpDampedRotarySpringSetRestAngle(cpConstraint *constraint, cpFloat restAngle);
        public void SetRestAngle(double restAngle) {
            CP.DampedRotarySpringSetRestAngle(constraint, restAngle);
        }

        // CP_EXPORT void cpDampedRotarySpringSetStiffness(cpConstraint *constraint, cpFloat stiffness);
        public void SetStiffness(double stiffness) {
            CP.DampedRotarySpringSetStiffness(constraint, stiffness);
        }

    }
}

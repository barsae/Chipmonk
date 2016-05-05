using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class DampedRotarySpring : Constraint {
        public DampedRotarySpring(Body a, Body b, double restAngle, double stiffness, double damping) : base(CP.DampedRotarySpringNew(a.Handle, b.Handle, restAngle, stiffness, damping)) {
        }

        public DampedRotarySpring(IntPtr handle) : base(handle) {
        }

        public static DampedRotarySpring Alloc() {
            return new DampedRotarySpring(CP.DampedRotarySpringAlloc());
        }

        public double GetDamping() {
            return CP.DampedRotarySpringGetDamping(Handle);
        }

        public double GetRestAngle() {
            return CP.DampedRotarySpringGetRestAngle(Handle);
        }

        public double GetStiffness() {
            return CP.DampedRotarySpringGetStiffness(Handle);
        }

        public DampedRotarySpring Init(Body a, Body b, double restAngle, double stiffness, double damping) {
            return new DampedRotarySpring(CP.DampedRotarySpringInit(Handle, a.Handle, b.Handle, restAngle, stiffness, damping));
        }

        public static Constraint New(Body a, Body b, double restAngle, double stiffness, double damping) {
            return new Constraint(CP.DampedRotarySpringNew(a.Handle, b.Handle, restAngle, stiffness, damping));
        }

        public void SetDamping(double damping) {
            CP.DampedRotarySpringSetDamping(Handle, damping);
        }

        public void SetRestAngle(double restAngle) {
            CP.DampedRotarySpringSetRestAngle(Handle, restAngle);
        }

        public void SetStiffness(double stiffness) {
            CP.DampedRotarySpringSetStiffness(Handle, stiffness);
        }

    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class DampedSpring : Constraint {
        public DampedSpring(Body a, Body b, Vect anchorA, Vect anchorB, double restLength, double stiffness, double damping) : base(CP.DampedSpringNew(a.Handle, b.Handle, anchorA, anchorB, restLength, stiffness, damping)) {
        }

        public DampedSpring(IntPtr handle) : base(handle) {
        }

        public static DampedSpring Alloc() {
            return new DampedSpring(CP.DampedSpringAlloc());
        }

        public Vect GetAnchorA() {
            return CP.DampedSpringGetAnchorA(Handle);
        }

        public Vect GetAnchorB() {
            return CP.DampedSpringGetAnchorB(Handle);
        }

        public double GetDamping() {
            return CP.DampedSpringGetDamping(Handle);
        }

        public double GetRestLength() {
            return CP.DampedSpringGetRestLength(Handle);
        }

        public double GetStiffness() {
            return CP.DampedSpringGetStiffness(Handle);
        }

        public DampedSpring Init(Body a, Body b, Vect anchorA, Vect anchorB, double restLength, double stiffness, double damping) {
            return new DampedSpring(CP.DampedSpringInit(Handle, a.Handle, b.Handle, anchorA, anchorB, restLength, stiffness, damping));
        }

        public static Constraint New(Body a, Body b, Vect anchorA, Vect anchorB, double restLength, double stiffness, double damping) {
            return new Constraint(CP.DampedSpringNew(a.Handle, b.Handle, anchorA, anchorB, restLength, stiffness, damping));
        }

        public void SetAnchorA(Vect anchorA) {
            CP.DampedSpringSetAnchorA(Handle, anchorA);
        }

        public void SetAnchorB(Vect anchorB) {
            CP.DampedSpringSetAnchorB(Handle, anchorB);
        }

        public void SetDamping(double damping) {
            CP.DampedSpringSetDamping(Handle, damping);
        }

        public void SetRestLength(double restLength) {
            CP.DampedSpringSetRestLength(Handle, restLength);
        }

        public void SetStiffness(double stiffness) {
            CP.DampedSpringSetStiffness(Handle, stiffness);
        }

    }
}

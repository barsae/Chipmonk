using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PinJoint : Constraint {
        public PinJoint(Body a, Body b, Vect anchorA, Vect anchorB) : base(CP.PinJointNew(a.Handle, b.Handle, anchorA, anchorB)) {
        }

        public PinJoint(IntPtr handle) : base(handle) {
        }

        public static PinJoint Alloc() {
            return new PinJoint(CP.PinJointAlloc());
        }

        public Vect GetAnchorA() {
            return CP.PinJointGetAnchorA(Handle);
        }

        public Vect GetAnchorB() {
            return CP.PinJointGetAnchorB(Handle);
        }

        public double GetDist() {
            return CP.PinJointGetDist(Handle);
        }

        public PinJoint Init(Body a, Body b, Vect anchorA, Vect anchorB) {
            return new PinJoint(CP.PinJointInit(Handle, a.Handle, b.Handle, anchorA, anchorB));
        }

        public static Constraint New(Body a, Body b, Vect anchorA, Vect anchorB) {
            return new Constraint(CP.PinJointNew(a.Handle, b.Handle, anchorA, anchorB));
        }

        public void SetAnchorA(Vect anchorA) {
            CP.PinJointSetAnchorA(Handle, anchorA);
        }

        public void SetAnchorB(Vect anchorB) {
            CP.PinJointSetAnchorB(Handle, anchorB);
        }

        public void SetDist(double dist) {
            CP.PinJointSetDist(Handle, dist);
        }

    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PivotJoint : Constraint {
        public PivotJoint(Body a, Body b, Vect pivot) : base(CP.PivotJointNew(a.Handle, b.Handle, pivot)) {
        }

        public PivotJoint(IntPtr handle) : base(handle) {
        }

        public static PivotJoint Alloc() {
            return new PivotJoint(CP.PivotJointAlloc());
        }

        public Vect GetAnchorA() {
            return CP.PivotJointGetAnchorA(Handle);
        }

        public Vect GetAnchorB() {
            return CP.PivotJointGetAnchorB(Handle);
        }

        public PivotJoint Init(Body a, Body b, Vect anchorA, Vect anchorB) {
            return new PivotJoint(CP.PivotJointInit(Handle, a.Handle, b.Handle, anchorA, anchorB));
        }

        public static Constraint New(Body a, Body b, Vect pivot) {
            return new Constraint(CP.PivotJointNew(a.Handle, b.Handle, pivot));
        }

        public static Constraint New2(Body a, Body b, Vect anchorA, Vect anchorB) {
            return new Constraint(CP.PivotJointNew2(a.Handle, b.Handle, anchorA, anchorB));
        }

        public void SetAnchorA(Vect anchorA) {
            CP.PivotJointSetAnchorA(Handle, anchorA);
        }

        public void SetAnchorB(Vect anchorB) {
            CP.PivotJointSetAnchorB(Handle, anchorB);
        }

    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class GrooveJoint : Constraint {
        public GrooveJoint(Body a, Body b, Vect groove_a, Vect groove_b, Vect anchorB) : base(CP.GrooveJointNew(a.Handle, b.Handle, groove_a, groove_b, anchorB)) {
        }

        public GrooveJoint(IntPtr handle) : base(handle) {
        }

        public static GrooveJoint Alloc() {
            return new GrooveJoint(CP.GrooveJointAlloc());
        }

        public Vect GetAnchorB() {
            return CP.GrooveJointGetAnchorB(Handle);
        }

        public Vect GetGrooveA() {
            return CP.GrooveJointGetGrooveA(Handle);
        }

        public Vect GetGrooveB() {
            return CP.GrooveJointGetGrooveB(Handle);
        }

        public GrooveJoint Init(Body a, Body b, Vect groove_a, Vect groove_b, Vect anchorB) {
            return new GrooveJoint(CP.GrooveJointInit(Handle, a.Handle, b.Handle, groove_a, groove_b, anchorB));
        }

        public static Constraint New(Body a, Body b, Vect groove_a, Vect groove_b, Vect anchorB) {
            return new Constraint(CP.GrooveJointNew(a.Handle, b.Handle, groove_a, groove_b, anchorB));
        }

        public void SetAnchorB(Vect anchorB) {
            CP.GrooveJointSetAnchorB(Handle, anchorB);
        }

        public void SetGrooveA(Vect grooveA) {
            CP.GrooveJointSetGrooveA(Handle, grooveA);
        }

        public void SetGrooveB(Vect grooveB) {
            CP.GrooveJointSetGrooveB(Handle, grooveB);
        }

    }
}

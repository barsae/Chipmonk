using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class SlideJoint : Constraint {
        public SlideJoint(Body a, Body b, Vect anchorA, Vect anchorB, double min, double max) : base(CP.SlideJointNew(a.Handle, b.Handle, anchorA, anchorB, min, max)) {
        }

        public SlideJoint(IntPtr handle) : base(handle) {
        }

        public static SlideJoint Alloc() {
            return new SlideJoint(CP.SlideJointAlloc());
        }

        public Vect GetAnchorA() {
            return CP.SlideJointGetAnchorA(Handle);
        }

        public Vect GetAnchorB() {
            return CP.SlideJointGetAnchorB(Handle);
        }

        public double GetMax() {
            return CP.SlideJointGetMax(Handle);
        }

        public double GetMin() {
            return CP.SlideJointGetMin(Handle);
        }

        public SlideJoint Init(Body a, Body b, Vect anchorA, Vect anchorB, double min, double max) {
            return new SlideJoint(CP.SlideJointInit(Handle, a.Handle, b.Handle, anchorA, anchorB, min, max));
        }

        public static Constraint New(Body a, Body b, Vect anchorA, Vect anchorB, double min, double max) {
            return new Constraint(CP.SlideJointNew(a.Handle, b.Handle, anchorA, anchorB, min, max));
        }

        public void SetAnchorA(Vect anchorA) {
            CP.SlideJointSetAnchorA(Handle, anchorA);
        }

        public void SetAnchorB(Vect anchorB) {
            CP.SlideJointSetAnchorB(Handle, anchorB);
        }

        public void SetMax(double max) {
            CP.SlideJointSetMax(Handle, max);
        }

        public void SetMin(double min) {
            CP.SlideJointSetMin(Handle, min);
        }

    }
}

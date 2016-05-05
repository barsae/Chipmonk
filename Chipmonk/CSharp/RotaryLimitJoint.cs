using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class RotaryLimitJoint : Constraint {
        public RotaryLimitJoint(Body a, Body b, double min, double max) : base(CP.RotaryLimitJointNew(a.Handle, b.Handle, min, max)) {
        }

        public RotaryLimitJoint(IntPtr handle) : base(handle) {
        }

        public static RotaryLimitJoint Alloc() {
            return new RotaryLimitJoint(CP.RotaryLimitJointAlloc());
        }

        public double GetMax() {
            return CP.RotaryLimitJointGetMax(Handle);
        }

        public double GetMin() {
            return CP.RotaryLimitJointGetMin(Handle);
        }

        public RotaryLimitJoint Init(Body a, Body b, double min, double max) {
            return new RotaryLimitJoint(CP.RotaryLimitJointInit(Handle, a.Handle, b.Handle, min, max));
        }

        public static Constraint New(Body a, Body b, double min, double max) {
            return new Constraint(CP.RotaryLimitJointNew(a.Handle, b.Handle, min, max));
        }

        public void SetMax(double max) {
            CP.RotaryLimitJointSetMax(Handle, max);
        }

        public void SetMin(double min) {
            CP.RotaryLimitJointSetMin(Handle, min);
        }

    }
}

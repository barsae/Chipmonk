using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class GearJoint : Constraint {
        public GearJoint(Body a, Body b, double phase, double ratio) : base(CP.GearJointNew(a.Handle, b.Handle, phase, ratio)) {
        }

        public GearJoint(IntPtr handle) : base(handle) {
        }

        public static GearJoint Alloc() {
            return new GearJoint(CP.GearJointAlloc());
        }

        public double GetPhase() {
            return CP.GearJointGetPhase(Handle);
        }

        public double GetRatio() {
            return CP.GearJointGetRatio(Handle);
        }

        public GearJoint Init(Body a, Body b, double phase, double ratio) {
            return new GearJoint(CP.GearJointInit(Handle, a.Handle, b.Handle, phase, ratio));
        }

        public static Constraint New(Body a, Body b, double phase, double ratio) {
            return new Constraint(CP.GearJointNew(a.Handle, b.Handle, phase, ratio));
        }

        public void SetPhase(double phase) {
            CP.GearJointSetPhase(Handle, phase);
        }

        public void SetRatio(double ratio) {
            CP.GearJointSetRatio(Handle, ratio);
        }

    }
}

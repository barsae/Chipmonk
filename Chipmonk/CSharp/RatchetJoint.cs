using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class RatchetJoint : Constraint {
        public RatchetJoint(Body a, Body b, double phase, double ratchet) : base(CP.RatchetJointNew(a.Handle, b.Handle, phase, ratchet)) {
        }

        public RatchetJoint(IntPtr handle) : base(handle) {
        }

        public static RatchetJoint Alloc() {
            return new RatchetJoint(CP.RatchetJointAlloc());
        }

        public double GetAngle() {
            return CP.RatchetJointGetAngle(Handle);
        }

        public double GetPhase() {
            return CP.RatchetJointGetPhase(Handle);
        }

        public double GetRatchet() {
            return CP.RatchetJointGetRatchet(Handle);
        }

        public RatchetJoint Init(Body a, Body b, double phase, double ratchet) {
            return new RatchetJoint(CP.RatchetJointInit(Handle, a.Handle, b.Handle, phase, ratchet));
        }

        public static Constraint New(Body a, Body b, double phase, double ratchet) {
            return new Constraint(CP.RatchetJointNew(a.Handle, b.Handle, phase, ratchet));
        }

        public void SetAngle(double angle) {
            CP.RatchetJointSetAngle(Handle, angle);
        }

        public void SetPhase(double phase) {
            CP.RatchetJointSetPhase(Handle, phase);
        }

        public void SetRatchet(double ratchet) {
            CP.RatchetJointSetRatchet(Handle, ratchet);
        }

    }
}

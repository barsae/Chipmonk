using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class RatchetJoint {
        public IntPtr constraint { get; set; }

        public RatchetJoint(IntPtr a, IntPtr b, double phase, double ratchet) {
            constraint = CP.RatchetJointNew(a, b, phase, ratchet);
        }

        // CP_EXPORT cpFloat cpRatchetJointGetAngle(const cpConstraint *constraint);
        public double GetAngle() {
            return CP.RatchetJointGetAngle(constraint);
        }

        // CP_EXPORT cpFloat cpRatchetJointGetPhase(const cpConstraint *constraint);
        public double GetPhase() {
            return CP.RatchetJointGetPhase(constraint);
        }

        // CP_EXPORT cpFloat cpRatchetJointGetRatchet(const cpConstraint *constraint);
        public double GetRatchet() {
            return CP.RatchetJointGetRatchet(constraint);
        }

        // CP_EXPORT void cpRatchetJointSetAngle(cpConstraint *constraint, cpFloat angle);
        public void SetAngle(double angle) {
            CP.RatchetJointSetAngle(constraint, angle);
        }

        // CP_EXPORT void cpRatchetJointSetPhase(cpConstraint *constraint, cpFloat phase);
        public void SetPhase(double phase) {
            CP.RatchetJointSetPhase(constraint, phase);
        }

        // CP_EXPORT void cpRatchetJointSetRatchet(cpConstraint *constraint, cpFloat ratchet);
        public void SetRatchet(double ratchet) {
            CP.RatchetJointSetRatchet(constraint, ratchet);
        }

    }
}

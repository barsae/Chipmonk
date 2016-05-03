using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class GearJoint {
        public IntPtr constraint { get; private set; }

        public GearJoint(Body a, Body b, double phase, double ratio) {
            constraint = CP.GearJointNew(a, b, phase, ratio);
        }

        // CP_EXPORT cpFloat cpGearJointGetPhase(const cpConstraint *constraint);
        public double GetPhase() {
            return CP.GearJointGetPhase(constraint);
        }

        // CP_EXPORT cpFloat cpGearJointGetRatio(const cpConstraint *constraint);
        public double GetRatio() {
            return CP.GearJointGetRatio(constraint);
        }

        // CP_EXPORT void cpGearJointSetPhase(cpConstraint *constraint, cpFloat phase);
        public void SetPhase(double phase) {
            CP.GearJointSetPhase(constraint, phase);
        }

        // CP_EXPORT void cpGearJointSetRatio(cpConstraint *constraint, cpFloat ratio);
        public void SetRatio(double ratio) {
            CP.GearJointSetRatio(constraint, ratio);
        }

    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PinJoint {
        public IntPtr constraint { get; set; }

        public PinJoint(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB) {
            constraint = CP.PinJointNew(a, b, anchorA, anchorB);
        }

        // CP_EXPORT cpVect cpPinJointGetAnchorA(const cpConstraint *constraint);
        public Vect GetAnchorA() {
            return CP.PinJointGetAnchorA(constraint);
        }

        // CP_EXPORT cpVect cpPinJointGetAnchorB(const cpConstraint *constraint);
        public Vect GetAnchorB() {
            return CP.PinJointGetAnchorB(constraint);
        }

        // CP_EXPORT cpFloat cpPinJointGetDist(const cpConstraint *constraint);
        public double GetDist() {
            return CP.PinJointGetDist(constraint);
        }

        // CP_EXPORT void cpPinJointSetAnchorA(cpConstraint *constraint, cpVect anchorA);
        public void SetAnchorA(Vect anchorA) {
            CP.PinJointSetAnchorA(constraint, anchorA);
        }

        // CP_EXPORT void cpPinJointSetAnchorB(cpConstraint *constraint, cpVect anchorB);
        public void SetAnchorB(Vect anchorB) {
            CP.PinJointSetAnchorB(constraint, anchorB);
        }

        // CP_EXPORT void cpPinJointSetDist(cpConstraint *constraint, cpFloat dist);
        public void SetDist(double dist) {
            CP.PinJointSetDist(constraint, dist);
        }

    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class GrooveJoint {
        public IntPtr constraint { get; private set; }

        public GrooveJoint(IntPtr a, IntPtr b, Vect groove_a, Vect groove_b, Vect anchorB) {
            constraint = CP.GrooveJointNew(a, b, groove_a, groove_b, anchorB);
        }

        // CP_EXPORT cpVect cpGrooveJointGetAnchorB(const cpConstraint *constraint);
        public Vect GetAnchorB() {
            return CP.GrooveJointGetAnchorB(constraint);
        }

        // CP_EXPORT cpVect cpGrooveJointGetGrooveA(const cpConstraint *constraint);
        public Vect GetGrooveA() {
            return CP.GrooveJointGetGrooveA(constraint);
        }

        // CP_EXPORT cpVect cpGrooveJointGetGrooveB(const cpConstraint *constraint);
        public Vect GetGrooveB() {
            return CP.GrooveJointGetGrooveB(constraint);
        }

        // CP_EXPORT void cpGrooveJointSetAnchorB(cpConstraint *constraint, cpVect anchorB);
        public void SetAnchorB(Vect anchorB) {
            CP.GrooveJointSetAnchorB(constraint, anchorB);
        }

        // CP_EXPORT void cpGrooveJointSetGrooveA(cpConstraint *constraint, cpVect grooveA);
        public void SetGrooveA(Vect grooveA) {
            CP.GrooveJointSetGrooveA(constraint, grooveA);
        }

        // CP_EXPORT void cpGrooveJointSetGrooveB(cpConstraint *constraint, cpVect grooveB);
        public void SetGrooveB(Vect grooveB) {
            CP.GrooveJointSetGrooveB(constraint, grooveB);
        }

    }
}

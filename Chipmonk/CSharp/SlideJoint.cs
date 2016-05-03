using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class SlideJoint {
        public IntPtr constraint { get; private set; }

        public SlideJoint(Body a, Body b, Vect anchorA, Vect anchorB, double min, double max) {
            constraint = CP.SlideJointNew(a, b, anchorA, anchorB, min, max);
        }

        // CP_EXPORT cpVect cpSlideJointGetAnchorA(const cpConstraint *constraint);
        public Vect GetAnchorA() {
            return CP.SlideJointGetAnchorA(constraint);
        }

        // CP_EXPORT cpVect cpSlideJointGetAnchorB(const cpConstraint *constraint);
        public Vect GetAnchorB() {
            return CP.SlideJointGetAnchorB(constraint);
        }

        // CP_EXPORT cpFloat cpSlideJointGetMax(const cpConstraint *constraint);
        public double GetMax() {
            return CP.SlideJointGetMax(constraint);
        }

        // CP_EXPORT cpFloat cpSlideJointGetMin(const cpConstraint *constraint);
        public double GetMin() {
            return CP.SlideJointGetMin(constraint);
        }

        // CP_EXPORT void cpSlideJointSetAnchorA(cpConstraint *constraint, cpVect anchorA);
        public void SetAnchorA(Vect anchorA) {
            CP.SlideJointSetAnchorA(constraint, anchorA);
        }

        // CP_EXPORT void cpSlideJointSetAnchorB(cpConstraint *constraint, cpVect anchorB);
        public void SetAnchorB(Vect anchorB) {
            CP.SlideJointSetAnchorB(constraint, anchorB);
        }

        // CP_EXPORT void cpSlideJointSetMax(cpConstraint *constraint, cpFloat max);
        public void SetMax(double max) {
            CP.SlideJointSetMax(constraint, max);
        }

        // CP_EXPORT void cpSlideJointSetMin(cpConstraint *constraint, cpFloat min);
        public void SetMin(double min) {
            CP.SlideJointSetMin(constraint, min);
        }

    }
}

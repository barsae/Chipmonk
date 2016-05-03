using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PivotJoint {
        public IntPtr constraint { get; private set; }

        public PivotJoint(IntPtr a, IntPtr b, Vect pivot) {
            constraint = CP.PivotJointNew(a, b, pivot);
        }

        // CP_EXPORT cpVect cpPivotJointGetAnchorA(const cpConstraint *constraint);
        public Vect GetAnchorA() {
            return CP.PivotJointGetAnchorA(constraint);
        }

        // CP_EXPORT cpVect cpPivotJointGetAnchorB(const cpConstraint *constraint);
        public Vect GetAnchorB() {
            return CP.PivotJointGetAnchorB(constraint);
        }

        // CP_EXPORT cpConstraint* cpPivotJointNew2(cpBody *a, cpBody *b, cpVect anchorA, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpNew2")]
        public static extern IntPtr New2(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        // CP_EXPORT void cpPivotJointSetAnchorA(cpConstraint *constraint, cpVect anchorA);
        public void SetAnchorA(Vect anchorA) {
            CP.PivotJointSetAnchorA(constraint, anchorA);
        }

        // CP_EXPORT void cpPivotJointSetAnchorB(cpConstraint *constraint, cpVect anchorB);
        public void SetAnchorB(Vect anchorB) {
            CP.PivotJointSetAnchorB(constraint, anchorB);
        }

    }
}

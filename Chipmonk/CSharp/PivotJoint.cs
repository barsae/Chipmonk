using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PivotJoint : Constraint {
        #region Properties
        public Vect AnchorA {
            get {
                return CP.PivotJointGetAnchorA(Handle);
            }
            set {
                CP.PivotJointSetAnchorA(Handle, value);
            }
        }

        public Vect AnchorB {
            get {
                return CP.PivotJointGetAnchorB(Handle);
            }
            set {
                CP.PivotJointSetAnchorB(Handle, value);
            }
        }
        #endregion Properties

        public PivotJoint(Body a, Body b, Vect pivot) {
            Handle = CP.PivotJointNew(a.Handle, b.Handle, pivot);
        }

        public PivotJoint(Body a, Body b, Vect anchorA, Vect anchorB) {
            Handle = CP.PivotJointNew2(a.Handle, b.Handle, anchorA, anchorB);
        }

    }
}

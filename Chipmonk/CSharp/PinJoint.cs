using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PinJoint : Constraint {
        #region Properties
        public Vect AnchorA {
            get {
                return CP.PinJointGetAnchorA(Handle);
            }
            set {
                CP.PinJointSetAnchorA(Handle, value);
            }
        }

        public Vect AnchorB {
            get {
                return CP.PinJointGetAnchorB(Handle);
            }
            set {
                CP.PinJointSetAnchorB(Handle, value);
            }
        }

        public double Dist {
            get {
                return CP.PinJointGetDist(Handle);
            }
            set {
                CP.PinJointSetDist(Handle, value);
            }
        }
        #endregion Properties

        public PinJoint(Body a, Body b, Vect anchorA, Vect anchorB) {
            Handle = CP.PinJointNew(a.Handle, b.Handle, anchorA, anchorB);
        }
    }
}

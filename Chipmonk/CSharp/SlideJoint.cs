using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class SlideJoint : Constraint {
        #region Properties
        public Vect AnchorA {
            get {
                return CP.SlideJointGetAnchorA(Handle);
            }
            set {
                CP.SlideJointSetAnchorA(Handle, value);
            }
        }

        public Vect AnchorB {
            get {
                return CP.SlideJointGetAnchorB(Handle);
            }
            set {
                CP.SlideJointSetAnchorB(Handle, value);
            }
        }

        public double Max {
            get {
                return CP.SlideJointGetMax(Handle);
            }
            set {
                CP.SlideJointSetMax(Handle, value);
            }
        }

        public double Min {
            get {
                return CP.SlideJointGetMin(Handle);
            }
            set {
                CP.SlideJointSetMin(Handle, value);
            }
        }
        #endregion Properties

        public SlideJoint(Body a, Body b, Vect anchorA, Vect anchorB, double min, double max) {
            Handle = CP.SlideJointNew(a.Handle, b.Handle, anchorA, anchorB, min, max);
        }
    }
}

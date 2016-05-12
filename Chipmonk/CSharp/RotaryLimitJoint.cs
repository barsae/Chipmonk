using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class RotaryLimitJoint : Constraint {
        #region Properties
        public double Max {
            get {
                return CP.RotaryLimitJointGetMax(Handle);
            }
            set {
                CP.RotaryLimitJointSetMax(Handle, value);
            }
        }

        public double Min {
            get {
                return CP.RotaryLimitJointGetMin(Handle);
            }
            set {
                CP.RotaryLimitJointSetMin(Handle, value);
            }
        }
        #endregion Properties

        public RotaryLimitJoint(Body a, Body b, double min, double max) {
            Handle = CP.RotaryLimitJointNew(a.Handle, b.Handle, min, max);
        }
    }
}

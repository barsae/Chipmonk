using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class GearJoint : Constraint {
        #region Properties
        public double Phase {
            get {
                return CP.GearJointGetPhase(Handle);
            }
            set {
                CP.GearJointSetPhase(Handle, value);
            }
        }

        public double Ratio {
            get {
                return CP.GearJointGetRatio(Handle);
            }
            set {
                CP.GearJointSetRatio(Handle, value);
            }
        }
        #endregion Properties

        public GearJoint(Body a, Body b, double phase, double ratio) {
            Handle = CP.GearJointNew(a.Handle, b.Handle, phase, ratio);
        }
    }
}

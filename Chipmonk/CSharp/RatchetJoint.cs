using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class RatchetJoint : Constraint {
        #region Properties
        public double Angle {
            get {
                return CP.RatchetJointGetAngle(Handle);
            }
            set {
                CP.RatchetJointSetAngle(Handle, value);
            }
        }

        public double Phase {
            get {
                return CP.RatchetJointGetPhase(Handle);
            }
            set {
                CP.RatchetJointSetPhase(Handle, value);
            }
        }

        public double Ratchet {
            get {
                return CP.RatchetJointGetRatchet(Handle);
            }
            set {
                CP.RatchetJointSetRatchet(Handle, value);
            }
        }
        #endregion Properties

        public RatchetJoint(Body a, Body b, double phase, double ratchet) {
            Handle = CP.RatchetJointNew(a.Handle, b.Handle, phase, ratchet);
        }
    }
}

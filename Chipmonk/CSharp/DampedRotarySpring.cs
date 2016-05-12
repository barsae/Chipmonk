using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class DampedRotarySpring : Constraint {
        #region Properties
        public double Damping {
            get {
                return CP.DampedRotarySpringGetDamping(Handle);
            }
            set {
                CP.DampedRotarySpringSetDamping(Handle, value);
            }
        }

        public double RestAngle {
            get {
                return CP.DampedRotarySpringGetRestAngle(Handle);
            }
            set {
                CP.DampedRotarySpringSetRestAngle(Handle, value);
            }
        }

        public double Stiffness {
            get {
                return CP.DampedRotarySpringGetStiffness(Handle);
            }
            set {
                CP.DampedRotarySpringSetStiffness(Handle, value);
            }
        }
        #endregion Properties

        public DampedRotarySpring(Body a, Body b, double restAngle, double stiffness, double damping) {
            Handle = CP.DampedRotarySpringNew(a.Handle, b.Handle, restAngle, stiffness, damping);
        }
    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class DampedSpring : Constraint {
        #region Properties
        public Vect AnchorA {
            get {
                return CP.DampedSpringGetAnchorA(Handle);
            }
        }

        public Vect AnchorB {
            get {
                return CP.DampedSpringGetAnchorB(Handle);
            }
            set {
                CP.DampedSpringSetAnchorB(Handle, value);
            }
        }

        public double Damping {
            get {
                return CP.DampedSpringGetDamping(Handle);
            }
            set {
                CP.DampedSpringGetDamping(Handle);
            }
        }

        public double RestLength {
            get {
                return CP.DampedSpringGetRestLength(Handle);
            }
            set {
                CP.DampedSpringSetRestLength(Handle, value);
            }
        }

        public double Stiffness {
            get {
                return CP.DampedSpringGetStiffness(Handle);
            }
            set {
                CP.DampedSpringSetStiffness(Handle, value);
            }
        }
        #endregion Properties

        public DampedSpring(Body a, Body b, Vect anchorA, Vect anchorB, double restLength, double stiffness, double damping) {
            Handle = CP.DampedSpringNew(a.Handle, b.Handle, anchorA, anchorB, restLength, stiffness, damping);
        }
    }
}

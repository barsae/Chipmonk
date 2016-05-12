using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class GrooveJoint : Constraint {
        #region Properties
        public Vect AnchorB {
            get {
                return CP.GrooveJointGetAnchorB(Handle);
            }
            set {
                CP.GrooveJointSetAnchorB(Handle, value);
            }
        }

        public Vect GrooveA {
            get {
                return CP.GrooveJointGetGrooveA(Handle);
            }
            set {
                CP.GrooveJointSetGrooveA(Handle, value);
            }
        }

        public Vect GrooveB {
            get {
                return CP.GrooveJointGetGrooveB(Handle);
            }
            set {
                CP.GrooveJointSetGrooveB(Handle, value);
            }
        }
        #endregion Properties

        public GrooveJoint(Body a, Body b, Vect groove_a, Vect groove_b, Vect anchorB) {
            Handle = CP.GrooveJointNew(a.Handle, b.Handle, groove_a, groove_b, anchorB);
        }
    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Arbiter {
        internal IntPtr Handle { get; set; }

        #region Properties
        public int Count {
            get {
                return CP.ArbiterGetCount(Handle);
            }
        }

        public double Friction {
            get {
                return CP.ArbiterGetFriction(Handle);
            }
            set {
                CP.ArbiterSetFriction(Handle, value);
            }
        }

        public Vect Normal {
            get {
                return CP.ArbiterGetNormal(Handle);
            }
        }

        public double Restitution {
            get {
                return CP.ArbiterGetRestitution(Handle);
            }
            set {
                CP.ArbiterSetRestitution(Handle, value);
            }
        }

        public Vect SurfaceVelocity {
            get {
                return CP.ArbiterGetSurfaceVelocity(Handle);
            }
            set {
                CP.ArbiterSetSurfaceVelocity(Handle, value);
            }
        }

        public IntPtr UserData {
            get {
                return CP.ArbiterGetUserData(Handle);
            }
            set {
                CP.ArbiterSetUserData(Handle, value);
            }
        }

        public Vect TotalImpulse {
            get {
                return CP.ArbiterTotalImpulse(Handle);
            }
        }

        public double TotalKE {
            get {
                return CP.ArbiterTotalKE(Handle);
            }
        }
        #endregion Properties

        internal Arbiter(IntPtr handle) {
            Handle = handle;
        }

        #region Methods
        public bool CallWildcardBeginA(Space space) {
            return CP.ArbiterCallWildcardBeginA(Handle, space.Handle);
        }

        public bool CallWildcardBeginB(Space space) {
            return CP.ArbiterCallWildcardBeginB(Handle, space.Handle);
        }

        public void CallWildcardPostSolveA(Space space) {
            CP.ArbiterCallWildcardPostSolveA(Handle, space.Handle);
        }

        public void CallWildcardPostSolveB(Space space) {
            CP.ArbiterCallWildcardPostSolveB(Handle, space.Handle);
        }

        public bool CallWildcardPreSolveA(Space space) {
            return CP.ArbiterCallWildcardPreSolveA(Handle, space.Handle);
        }

        public bool CallWildcardPreSolveB(Space space) {
            return CP.ArbiterCallWildcardPreSolveB(Handle, space.Handle);
        }

        public void CallWildcardSeparateA(Space space) {
            CP.ArbiterCallWildcardSeparateA(Handle, space.Handle);
        }

        public void CallWildcardSeparateB(Space space) {
            CP.ArbiterCallWildcardSeparateB(Handle, space.Handle);
        }

        public void GetBodies(IntPtr a, IntPtr b) {
            CP.ArbiterGetBodies(Handle, a, b);
        }

        public double GetDepth(int i) {
            return CP.ArbiterGetDepth(Handle, i);
        }

        public Vect GetPointA(int i) {
            return CP.ArbiterGetPointA(Handle, i);
        }

        public Vect GetPointB(int i) {
            return CP.ArbiterGetPointB(Handle, i);
        }

        public void GetShapes(IntPtr a, IntPtr b) {
            CP.ArbiterGetShapes(Handle, a, b);
        }

        public bool Ignore() {
            return CP.ArbiterIgnore(Handle);
        }

        public bool IsFirstContact() {
            return CP.ArbiterIsFirstContact(Handle);
        }

        public bool IsRemoval() {
            return CP.ArbiterIsRemoval(Handle);
        }

        public void SetContactPointSet(IntPtr set) {
            CP.ArbiterSetContactPointSet(Handle, set);
        }
        #endregion Methods
    }
}

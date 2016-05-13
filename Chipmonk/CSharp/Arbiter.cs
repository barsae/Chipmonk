using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Arbiter {
        internal IntPtr Handle { get; private set; }

        #region Properties
        public Body[] Bodies {
            get {
                var handle1 = new int[8];
                var handle2 = new int[8];
                var handlePointer1 = GCHandle.Alloc(handle1, GCHandleType.Pinned);
                var handlePointer2 = GCHandle.Alloc(handle2, GCHandleType.Pinned);
                CP.ArbiterGetBodies(Handle,
                                    handlePointer1.AddrOfPinnedObject(),
                                    handlePointer2.AddrOfPinnedObject());

                var bodies = new Body[] {
                    new Body((IntPtr)handlePointer1.Target),
                    new Body((IntPtr)handlePointer2.Target)
                };

                handlePointer1.Free();
                handlePointer2.Free();

                return bodies;
            }
        }

        public Contact[] Contacts {
            get {
                var count = CP.ArbiterGetCount(Handle);
                var contacts = new Contact[count];

                for (int ii = 0; ii < count; ii++) {
                    contacts[ii] = new Contact() {
                        Depth = CP.ArbiterGetDepth(Handle, ii),
                        PointA = CP.ArbiterGetPointA(Handle, ii),
                        PointB = CP.ArbiterGetPointB(Handle, ii)
                    };
                }

                return contacts;
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

        public bool IsFirstContact {
            get {
                return CP.ArbiterIsFirstContact(Handle);
            }
        }

        public bool IsRemoval {
            get {
                return CP.ArbiterIsRemoval(Handle);
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

        public void GetShapes(IntPtr a, IntPtr b) {
            CP.ArbiterGetShapes(Handle, a, b);
        }

        public bool Ignore() {
            return CP.ArbiterIgnore(Handle);
        }

        public void SetContactPointSet(IntPtr set) {
            CP.ArbiterSetContactPointSet(Handle, set);
        }
        #endregion Methods
    }
}

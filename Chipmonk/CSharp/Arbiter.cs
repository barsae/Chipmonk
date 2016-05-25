using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Arbiter : ForeignReference {
        #region Properties
        public Body[] Bodies {
            get {
                var handle1 = new IntPtr();
                var handle2 = new IntPtr();
                CP.ArbiterGetBodies(Handle, ref handle1, ref handle2);

                var bodies = new Body[] {
                    new Body(handle1),
                    new Body(handle2)
                };

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

        public Shape[] Shapes {
            get {
                var handle1 = new IntPtr();
                var handle2 = new IntPtr();
                CP.ArbiterGetShapes(Handle, ref handle1, ref handle2);

                var shapes = new Shape[] {
                    new Shape(handle1),
                    new Shape(handle2)
                };

                return shapes;
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

        public object UserData {
            get {
                var id = CP.ArbiterGetUserData(Handle);
                return ReferenceManager.Dereference(id);
            }
            set {
                var previousId = CP.ArbiterGetUserData(Handle);
                ReferenceManager.DeallocateReference(previousId);

                var newId = ReferenceManager.AllocateReference(value);
                CP.ArbiterSetUserData(Handle, newId);
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

        public bool Ignore() {
            return CP.ArbiterIgnore(Handle);
        }

        public void SetContactPointSet(IntPtr set) {
            CP.ArbiterSetContactPointSet(Handle, set);
        }
        #endregion Methods
    }
}

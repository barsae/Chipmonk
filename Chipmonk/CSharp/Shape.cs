using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Shape : ForeignReference, IDisposable {
        #region Properties
        public double Area {
            get {
                return CP.ShapeGetArea(Handle);
            }
        }

        public BB BB {
            get {
                return CP.ShapeGetBB(Handle);
            }
        }

        public Body Body {
            get {
                return new Body(CP.ShapeGetBody(Handle));
            }
        }

        public BB CacheBB {
            get {
                return CP.ShapeCacheBB(Handle);
            }
        }

        public Vect CenterOfGravity {
            get {
                return CP.ShapeGetCenterOfGravity(Handle);
            }
        }

        public double Density {
            get {
                return CP.ShapeGetDensity(Handle);
            }
            set {
                CP.ShapeSetDensity(Handle, value);
            }
        }

        public double Elasticity {
            get {
                return CP.ShapeGetElasticity(Handle);
            }
            set {
                CP.ShapeSetElasticity(Handle, value);
            }
        }

        public double Friction {
            get {
                return CP.ShapeGetFriction(Handle);
            }
            set {
                CP.ShapeSetFriction(Handle, value);
            }
        }

        public double Mass {
            get {
                return CP.ShapeGetMass(Handle);
            }
            set {
                CP.ShapeSetMass(Handle, value);
            }
        }

        public double Moment {
            get {
                return CP.ShapeGetMoment(Handle);
            }
        }

        public bool Sensor {
            get {
                return CP.ShapeGetSensor(Handle);
            }
            set {
                CP.ShapeSetSensor(Handle, value);
            }
        }

        public Space Space {
            get {
                return new Space(CP.ShapeGetSpace(Handle));
            }
        }

        public Vect SurfaceVelocity {
            get {
                return CP.ShapeGetSurfaceVelocity(Handle);
            }
            set {
                CP.ShapeSetSurfaceVelocity(Handle, value);
            }
        }

        public object UserData {
            get {
                var id = CP.ShapeGetUserData(Handle);
                return ReferenceManager.Dereference(id);
            }
            set {
                var previousId = CP.ShapeGetUserData(Handle);
                ReferenceManager.DeallocateReference(previousId);

                var newId = ReferenceManager.AllocateReference(value);
                CP.ShapeSetUserData(Handle, newId);
            }
        }
        #endregion Properties

        internal Shape() {
            // Child class must set Handle, or bad things will happen
        }

        internal Shape(IntPtr handle) {
            Handle = handle;
        }

        public virtual void Dispose() {
            CP.ShapeFree(Handle);
        }

        public double PointQuery(Vect p, IntPtr output) {
            return CP.ShapePointQuery(Handle, p, output);
        }

        public bool SegmentQuery(Vect a, Vect b, double radius, IntPtr info) {
            return CP.ShapeSegmentQuery(Handle, a, b, radius, info);
        }
    }
}

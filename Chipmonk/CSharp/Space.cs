using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Space : ForeignReference, IDisposable {
        #region Properties
        public double CollisionBias {
            get {
                return CP.SpaceGetCollisionBias(Handle);
            }
            set {
                CP.SpaceSetCollisionBias(Handle, value);
            }
        }

        public double CollisionSlop {
            get {
                return CP.SpaceGetCollisionSlop(Handle);
            }
            set {
                CP.SpaceSetCollisionSlop(Handle, value);
            }
        }

        public double CurrentTimeStep {
            get {
                return CP.SpaceGetCurrentTimeStep(Handle);
            }
        }

        public double Damping {
            get {
                return CP.SpaceGetDamping(Handle);
            }
            set {
                CP.SpaceSetDamping(Handle, value);
            }
        }

        public Vect Gravity {
            get {
                return CP.SpaceGetGravity(Handle);
            }
            set {
                CP.SpaceSetGravity(Handle, value);
            }
        }

        public double IdleSpeedThreshold {
            get {
                return CP.SpaceGetIdleSpeedThreshold(Handle);
            }
            set {
                CP.SpaceSetIdleSpeedThreshold(Handle, value);
            }
        }

        public int Iterations {
            get {
                return CP.SpaceGetIterations(Handle);
            }
            set {
                CP.SpaceSetIterations(Handle, value);
            }
        }

        public double SleepTimeThreshold {
            get {
                return CP.SpaceGetSleepTimeThreshold(Handle);
            }
            set {
                CP.SpaceSetSleepTimeThreshold(Handle, value);
            }
        }

        public Body StaticBody {
            get {
                return new Body(CP.SpaceGetStaticBody(Handle));
            }
        }

        public object UserData {
            get {
                var id = CP.SpaceGetUserData(Handle);
                return ReferenceManager.Dereference(id);
            }
            set {
                var previousId = CP.SpaceGetUserData(Handle);
                ReferenceManager.DeallocateReference(previousId);

                var newId = ReferenceManager.AllocateReference(value);
                CP.SpaceSetUserData(Handle, newId);
            }
        }

        public bool IsLocked {
            get {
                return CP.SpaceIsLocked(Handle);
            }
        }
        #endregion Properties

        public Space() {
            Handle = CP.SpaceNew();
        }

        internal Space(IntPtr handle) {
            Handle = handle;
        }

        public Body AddBody(Body body) {
            return new Body(CP.SpaceAddBody(Handle, body.Handle));
        }

        public CollisionHandlerWrapper AddCollisionHandler(uint a, uint b, ICollisionHandler handler) {
            return new CollisionHandlerWrapper(CP.SpaceAddCollisionHandler(Handle, a, b), handler);
        }

        public Constraint AddConstraint(Constraint constraint) {
            return new Constraint(CP.SpaceAddConstraint(Handle, constraint.Handle));
        }

        public CollisionHandlerWrapper AddDefaultCollisionHandler(ICollisionHandler handler) {
            return new CollisionHandlerWrapper(CP.SpaceAddDefaultCollisionHandler(Handle), handler);
        }

        public Shape AddShape(Shape shape) {
            return new Shape(CP.SpaceAddShape(Handle, shape.Handle));
        }

        public bool ContainsBody(Body body) {
            return CP.SpaceContainsBody(Handle, body.Handle);
        }

        public bool ContainsConstraint(Constraint constraint) {
            return CP.SpaceContainsConstraint(Handle, constraint.Handle);
        }

        public bool ContainsShape(Shape shape) {
            return CP.SpaceContainsShape(Handle, shape.Handle);
        }

        public void DebugDraw(IntPtr options) {
            CP.SpaceDebugDraw(Handle, options);
        }

        public void Dispose() {
            CP.SpaceFree(Handle);
        }

        public void HastySpaceSetThreads(ulong threads) {
            CP.HastySpaceSetThreads(Handle, threads);
        }

        public void HastySpaceStep(double dt) {
            CP.HastySpaceStep(Handle, dt);
        }

        public void ReindexShape(Shape shape) {
            CP.SpaceReindexShape(Handle, shape.Handle);
        }

        public void ReindexShapesForBody(Body body) {
            CP.SpaceReindexShapesForBody(Handle, body.Handle);
        }

        public void ReindexStatic() {
            CP.SpaceReindexStatic(Handle);
        }

        public void RemoveBody(Body body) {
            CP.SpaceRemoveBody(Handle, body.Handle);
        }

        public void RemoveConstraint(Constraint constraint) {
            CP.SpaceRemoveConstraint(Handle, constraint.Handle);
        }

        public void RemoveShape(Shape shape) {
            CP.SpaceRemoveShape(Handle, shape.Handle);
        }

        public void Step(double dt) {
            CP.SpaceStep(Handle, dt);
        }

        public void UseSpatialHash(double dim, int count) {
            CP.SpaceUseSpatialHash(Handle, dim, count);
        }
    }
}

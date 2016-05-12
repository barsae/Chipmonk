using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Space {
        public IntPtr Handle { get; set; }

        public Space() {
            Handle = CP.SpaceNew();
        }

        internal Space(IntPtr handle) {
            Handle = handle;
        }

        public Body AddBody(Body body) {
            return new Body(CP.SpaceAddBody(Handle, body.Handle));
        }

        public Constraint AddConstraint(Constraint constraint) {
            return new Constraint(CP.SpaceAddConstraint(Handle, constraint.Handle));
        }

        public IntPtr AddDefaultCollisionHandler() {
            return CP.SpaceAddDefaultCollisionHandler(Handle);
        }

        public Shape AddShape(Shape shape) {
            return new Shape(CP.SpaceAddShape(Handle, shape.Handle));
        }

        public static Space Alloc() {
            return new Space(CP.SpaceAlloc());
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

        public void Destroy() {
            CP.SpaceDestroy(Handle);
        }

        public void Free() {
            CP.SpaceFree(Handle);
        }

        public double GetCollisionBias() {
            return CP.SpaceGetCollisionBias(Handle);
        }

        public double GetCollisionSlop() {
            return CP.SpaceGetCollisionSlop(Handle);
        }

        public double GetCurrentTimeStep() {
            return CP.SpaceGetCurrentTimeStep(Handle);
        }

        public double GetDamping() {
            return CP.SpaceGetDamping(Handle);
        }

        public Vect GetGravity() {
            return CP.SpaceGetGravity(Handle);
        }

        public double GetIdleSpeedThreshold() {
            return CP.SpaceGetIdleSpeedThreshold(Handle);
        }

        public int GetIterations() {
            return CP.SpaceGetIterations(Handle);
        }

        public double GetSleepTimeThreshold() {
            return CP.SpaceGetSleepTimeThreshold(Handle);
        }

        public Body GetStaticBody() {
            return new Body(CP.SpaceGetStaticBody(Handle));
        }

        public IntPtr GetUserData() {
            return CP.SpaceGetUserData(Handle);
        }

        public static IntPtr HashAlloc() {
            return CP.SpaceHashAlloc();
        }

        public static void HashResize(IntPtr hash, double celldim, int numcells) {
            CP.SpaceHashResize(hash, celldim, numcells);
        }

        public void HastySpaceFree() {
            CP.HastySpaceFree(Handle);
        }

        public void HastySpaceSetThreads(UInt64 threads) {
            CP.HastySpaceSetThreads(Handle, threads);
        }

        public void HastySpaceStep(double dt) {
            CP.HastySpaceStep(Handle, dt);
        }

        public Space Init() {
            return new Space(CP.SpaceInit(Handle));
        }

        public bool IsLocked() {
            return CP.SpaceIsLocked(Handle);
        }

        public static Space New() {
            return new Space(CP.SpaceNew());
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

        public void SetCollisionBias(double collisionBias) {
            CP.SpaceSetCollisionBias(Handle, collisionBias);
        }

        public void SetCollisionSlop(double collisionSlop) {
            CP.SpaceSetCollisionSlop(Handle, collisionSlop);
        }

        public void SetDamping(double damping) {
            CP.SpaceSetDamping(Handle, damping);
        }

        public void SetGravity(Vect gravity) {
            CP.SpaceSetGravity(Handle, gravity);
        }

        public void SetIdleSpeedThreshold(double idleSpeedThreshold) {
            CP.SpaceSetIdleSpeedThreshold(Handle, idleSpeedThreshold);
        }

        public void SetIterations(int iterations) {
            CP.SpaceSetIterations(Handle, iterations);
        }

        public void SetSleepTimeThreshold(double sleepTimeThreshold) {
            CP.SpaceSetSleepTimeThreshold(Handle, sleepTimeThreshold);
        }

        public void SetUserData(IntPtr userData) {
            CP.SpaceSetUserData(Handle, userData);
        }

        public void Step(double dt) {
            CP.SpaceStep(Handle, dt);
        }

        public void UseSpatialHash(double dim, int count) {
            CP.SpaceUseSpatialHash(Handle, dim, count);
        }

    }
}

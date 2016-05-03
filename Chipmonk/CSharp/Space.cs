using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Space {
        public IntPtr space { get; private set; }

        public Space() {
            space = CP.SpaceNew();
        }

        // CP_EXPORT cpBody* cpSpaceAddBody(cpSpace *space, cpBody *body);
        public Body AddBody(Body body) {
            return new Body(CP.SpaceAddBody(space, body.body));
        }

        // CP_EXPORT cpConstraint* cpSpaceAddConstraint(cpSpace *space, cpConstraint *constraint);
        public IntPtr AddConstraint(IntPtr constraint) {
            return CP.SpaceAddConstraint(space, constraint);
        }

        // CP_EXPORT cpCollisionHandler *cpSpaceAddDefaultCollisionHandler(cpSpace *space);
        public IntPtr AddDefaultCollisionHandler() {
            return CP.SpaceAddDefaultCollisionHandler(space);
        }

        // CP_EXPORT cpShape* cpSpaceAddShape(cpSpace *space, cpShape *shape);
        public IntPtr AddShape(IntPtr shape) {
            return CP.SpaceAddShape(space, shape);
        }

        // CP_EXPORT cpBool cpSpaceContainsBody(cpSpace *space, cpBody *body);
        public bool ContainsBody(Body body) {
            return CP.SpaceContainsBody(space, body);
        }

        // CP_EXPORT cpBool cpSpaceContainsConstraint(cpSpace *space, cpConstraint *constraint);
        public bool ContainsConstraint(IntPtr constraint) {
            return CP.SpaceContainsConstraint(space, constraint);
        }

        // CP_EXPORT cpBool cpSpaceContainsShape(cpSpace *space, cpShape *shape);
        public bool ContainsShape(IntPtr shape) {
            return CP.SpaceContainsShape(space, shape);
        }

        // CP_EXPORT void cpSpaceDebugDraw(cpSpace *space, cpSpaceDebugDrawOptions *options);
        public void DebugDraw(IntPtr options) {
            CP.SpaceDebugDraw(space, options);
        }

        // CP_EXPORT cpFloat cpSpaceGetCollisionBias(const cpSpace *space);
        public double GetCollisionBias() {
            return CP.SpaceGetCollisionBias(space);
        }

        // CP_EXPORT cpFloat cpSpaceGetCollisionSlop(const cpSpace *space);
        public double GetCollisionSlop() {
            return CP.SpaceGetCollisionSlop(space);
        }

        // CP_EXPORT cpFloat cpSpaceGetCurrentTimeStep(const cpSpace *space);
        public double GetCurrentTimeStep() {
            return CP.SpaceGetCurrentTimeStep(space);
        }

        // CP_EXPORT cpFloat cpSpaceGetDamping(const cpSpace *space);
        public double GetDamping() {
            return CP.SpaceGetDamping(space);
        }

        // CP_EXPORT cpVect cpSpaceGetGravity(const cpSpace *space);
        public Vect GetGravity() {
            return CP.SpaceGetGravity(space);
        }

        // CP_EXPORT cpFloat cpSpaceGetIdleSpeedThreshold(const cpSpace *space);
        public double GetIdleSpeedThreshold() {
            return CP.SpaceGetIdleSpeedThreshold(space);
        }

        // CP_EXPORT int cpSpaceGetIterations(const cpSpace *space);
        public int GetIterations() {
            return CP.SpaceGetIterations(space);
        }

        // CP_EXPORT cpFloat cpSpaceGetSleepTimeThreshold(const cpSpace *space);
        public double GetSleepTimeThreshold() {
            return CP.SpaceGetSleepTimeThreshold(space);
        }

        // CP_EXPORT cpBody* cpSpaceGetStaticBody(const cpSpace *space);
        public Body GetStaticBody() {
            return CP.SpaceGetStaticBody(space);
        }

        // CP_EXPORT cpDataPointer cpSpaceGetUserData(const cpSpace *space);
        public IntPtr GetUserData() {
            return CP.SpaceGetUserData(space);
        }

        // CP_EXPORT cpSpaceHash* cpSpaceHashAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHashAlloc")]
        public static extern IntPtr HashAlloc();

        // CP_EXPORT void cpSpaceHashResize(cpSpaceHash *hash, cpFloat celldim, int numcells);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHashResize")]
        public static extern void HashResize(IntPtr hash, double celldim, int numcells);

        // CP_EXPORT cpBool cpSpaceIsLocked(cpSpace *space);
        public bool IsLocked() {
            return CP.SpaceIsLocked(space);
        }

        // CP_EXPORT void cpSpaceReindexShape(cpSpace *space, cpShape *shape);
        public void ReindexShape(IntPtr shape) {
            CP.SpaceReindexShape(space, shape);
        }

        // CP_EXPORT void cpSpaceReindexShapesForBody(cpSpace *space, cpBody *body);
        public void ReindexShapesForBody(Body body) {
            CP.SpaceReindexShapesForBody(space, body);
        }

        // CP_EXPORT void cpSpaceReindexStatic(cpSpace *space);
        public void ReindexStatic() {
            CP.SpaceReindexStatic(space);
        }

        // CP_EXPORT void cpSpaceRemoveBody(cpSpace *space, cpBody *body);
        public void RemoveBody(Body body) {
            CP.SpaceRemoveBody(space, body);
        }

        // CP_EXPORT void cpSpaceRemoveConstraint(cpSpace *space, cpConstraint *constraint);
        public void RemoveConstraint(IntPtr constraint) {
            CP.SpaceRemoveConstraint(space, constraint);
        }

        // CP_EXPORT void cpSpaceRemoveShape(cpSpace *space, cpShape *shape);
        public void RemoveShape(IntPtr shape) {
            CP.SpaceRemoveShape(space, shape);
        }

        // CP_EXPORT void cpSpaceSetCollisionBias(cpSpace *space, cpFloat collisionBias);
        public void SetCollisionBias(double collisionBias) {
            CP.SpaceSetCollisionBias(space, collisionBias);
        }

        // CP_EXPORT void cpSpaceSetCollisionSlop(cpSpace *space, cpFloat collisionSlop);
        public void SetCollisionSlop(double collisionSlop) {
            CP.SpaceSetCollisionSlop(space, collisionSlop);
        }

        // CP_EXPORT void cpSpaceSetDamping(cpSpace *space, cpFloat damping);
        public void SetDamping(double damping) {
            CP.SpaceSetDamping(space, damping);
        }

        // CP_EXPORT void cpSpaceSetGravity(cpSpace *space, cpVect gravity);
        public void SetGravity(Vect gravity) {
            CP.SpaceSetGravity(space, gravity);
        }

        // CP_EXPORT void cpSpaceSetIdleSpeedThreshold(cpSpace *space, cpFloat idleSpeedThreshold);
        public void SetIdleSpeedThreshold(double idleSpeedThreshold) {
            CP.SpaceSetIdleSpeedThreshold(space, idleSpeedThreshold);
        }

        // CP_EXPORT void cpSpaceSetIterations(cpSpace *space, int iterations);
        public void SetIterations(int iterations) {
            CP.SpaceSetIterations(space, iterations);
        }

        // CP_EXPORT void cpSpaceSetSleepTimeThreshold(cpSpace *space, cpFloat sleepTimeThreshold);
        public void SetSleepTimeThreshold(double sleepTimeThreshold) {
            CP.SpaceSetSleepTimeThreshold(space, sleepTimeThreshold);
        }

        // CP_EXPORT void cpSpaceSetUserData(cpSpace *space, cpDataPointer userData);
        public void SetUserData(IntPtr userData) {
            CP.SpaceSetUserData(space, userData);
        }

        // CP_EXPORT void cpSpaceStep(cpSpace *space, cpFloat dt);
        public void Step(double dt) {
            CP.SpaceStep(space, dt);
        }

        // CP_EXPORT void cpSpaceUseSpatialHash(cpSpace *space, cpFloat dim, int count);
        public void UseSpatialHash(double dim, int count) {
            CP.SpaceUseSpatialHash(space, dim, count);
        }

    }
}

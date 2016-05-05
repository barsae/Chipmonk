using System;
using System.Runtime.InteropServices;

namespace Chipmonk.CApi {
    public static class CP {
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMessage")]
        public static extern void cpMessage(IntPtr condition, IntPtr file, int line, int isError, int isHardError, IntPtr message, params object[] varargs);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForCircle")]
        public static extern double cpMomentForCircle(double m, double r1, double r2, Vect offset);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpAreaForCircle")]
        public static extern double cpAreaForCircle(double r1, double r2);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForSegment")]
        public static extern double cpMomentForSegment(double m, Vect a, Vect b, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpAreaForSegment")]
        public static extern double cpAreaForSegment(Vect a, Vect b, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForPoly")]
        public static extern double cpMomentForPoly(double m, int count, IntPtr verts, Vect offset, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpAreaForPoly")]
        public static extern double cpAreaForPoly(int count, IntPtr verts, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCentroidForPoly")]
        public static extern Vect cpCentroidForPoly(int count, IntPtr verts);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForBox")]
        public static extern double cpMomentForBox(double m, double width, double height);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForBox2")]
        public static extern double cpMomentForBox2(double m, BB box);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConvexHull")]
        public static extern int cpConvexHull(int count, IntPtr verts, IntPtr result, IntPtr first, double tol);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeSetRadius")]
        public static extern void cpCircleShapeSetRadius(IntPtr shape, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeSetOffset")]
        public static extern void cpCircleShapeSetOffset(IntPtr shape, Vect offset);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeSetEndpoints")]
        public static extern void cpSegmentShapeSetEndpoints(IntPtr shape, Vect a, Vect b);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeSetRadius")]
        public static extern void cpSegmentShapeSetRadius(IntPtr shape, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeSetVertsRaw")]
        public static extern void cpPolyShapeSetVertsRaw(IntPtr shape, int count, IntPtr verts);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeSetRadius")]
        public static extern void cpPolyShapeSetRadius(IntPtr shape, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetRestitution")]
        public static extern double cpArbiterGetRestitution(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetRestitution")]
        public static extern void cpArbiterSetRestitution(IntPtr arb, double restitution);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetFriction")]
        public static extern double cpArbiterGetFriction(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetFriction")]
        public static extern void cpArbiterSetFriction(IntPtr arb, double friction);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetSurfaceVelocity")]
        public static extern Vect cpArbiterGetSurfaceVelocity(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetSurfaceVelocity")]
        public static extern void cpArbiterSetSurfaceVelocity(IntPtr arb, Vect vr);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetUserData")]
        public static extern IntPtr cpArbiterGetUserData(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetUserData")]
        public static extern void cpArbiterSetUserData(IntPtr arb, IntPtr userData);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterTotalImpulse")]
        public static extern Vect cpArbiterTotalImpulse(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterTotalKE")]
        public static extern double cpArbiterTotalKE(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterIgnore")]
        public static extern bool cpArbiterIgnore(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetShapes")]
        public static extern void cpArbiterGetShapes(IntPtr arb, IntPtr a, IntPtr b);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetBodies")]
        public static extern void cpArbiterGetBodies(IntPtr arb, IntPtr a, IntPtr b);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetContactPointSet")]
        public static extern void cpArbiterSetContactPointSet(IntPtr arb, IntPtr set);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterIsFirstContact")]
        public static extern bool cpArbiterIsFirstContact(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterIsRemoval")]
        public static extern bool cpArbiterIsRemoval(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetCount")]
        public static extern int cpArbiterGetCount(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetNormal")]
        public static extern Vect cpArbiterGetNormal(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetPointA")]
        public static extern Vect cpArbiterGetPointA(IntPtr arb, int i);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetPointB")]
        public static extern Vect cpArbiterGetPointB(IntPtr arb, int i);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetDepth")]
        public static extern double cpArbiterGetDepth(IntPtr arb, int i);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardBeginA")]
        public static extern bool cpArbiterCallWildcardBeginA(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardBeginB")]
        public static extern bool cpArbiterCallWildcardBeginB(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPreSolveA")]
        public static extern bool cpArbiterCallWildcardPreSolveA(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPreSolveB")]
        public static extern bool cpArbiterCallWildcardPreSolveB(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPostSolveA")]
        public static extern void cpArbiterCallWildcardPostSolveA(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPostSolveB")]
        public static extern void cpArbiterCallWildcardPostSolveB(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardSeparateA")]
        public static extern void cpArbiterCallWildcardSeparateA(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardSeparateB")]
        public static extern void cpArbiterCallWildcardSeparateB(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyAlloc")]
        public static extern IntPtr cpBodyAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyInit")]
        public static extern IntPtr cpBodyInit(IntPtr body, double mass, double moment);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyNew")]
        public static extern IntPtr cpBodyNew(double mass, double moment);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyNewKinematic")]
        public static extern IntPtr cpBodyNewKinematic();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyNewStatic")]
        public static extern IntPtr cpBodyNewStatic();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyDestroy")]
        public static extern void cpBodyDestroy(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyFree")]
        public static extern void cpBodyFree(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyActivate")]
        public static extern void cpBodyActivate(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyActivateStatic")]
        public static extern void cpBodyActivateStatic(IntPtr body, IntPtr filter);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySleep")]
        public static extern void cpBodySleep(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySleepWithGroup")]
        public static extern void cpBodySleepWithGroup(IntPtr body, IntPtr group);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyIsSleeping")]
        public static extern bool cpBodyIsSleeping(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetType")]
        public static extern BodyType cpBodyGetType(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetType")]
        public static extern void cpBodySetType(IntPtr body, BodyType type);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetSpace")]
        public static extern IntPtr cpBodyGetSpace(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetMass")]
        public static extern double cpBodyGetMass(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetMass")]
        public static extern void cpBodySetMass(IntPtr body, double m);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetMoment")]
        public static extern double cpBodyGetMoment(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetMoment")]
        public static extern void cpBodySetMoment(IntPtr body, double i);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetPosition")]
        public static extern Vect cpBodyGetPosition(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetPosition")]
        public static extern void cpBodySetPosition(IntPtr body, Vect pos);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetCenterOfGravity")]
        public static extern Vect cpBodyGetCenterOfGravity(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetCenterOfGravity")]
        public static extern void cpBodySetCenterOfGravity(IntPtr body, Vect cog);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetVelocity")]
        public static extern Vect cpBodyGetVelocity(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetVelocity")]
        public static extern void cpBodySetVelocity(IntPtr body, Vect velocity);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetForce")]
        public static extern Vect cpBodyGetForce(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetForce")]
        public static extern void cpBodySetForce(IntPtr body, Vect force);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetAngle")]
        public static extern double cpBodyGetAngle(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetAngle")]
        public static extern void cpBodySetAngle(IntPtr body, double a);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetAngularVelocity")]
        public static extern double cpBodyGetAngularVelocity(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetAngularVelocity")]
        public static extern void cpBodySetAngularVelocity(IntPtr body, double angularVelocity);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetTorque")]
        public static extern double cpBodyGetTorque(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetTorque")]
        public static extern void cpBodySetTorque(IntPtr body, double torque);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetRotation")]
        public static extern Vect cpBodyGetRotation(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetUserData")]
        public static extern IntPtr cpBodyGetUserData(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetUserData")]
        public static extern void cpBodySetUserData(IntPtr body, IntPtr userData);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyUpdateVelocity")]
        public static extern void cpBodyUpdateVelocity(IntPtr body, Vect gravity, double damping, double dt);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyUpdatePosition")]
        public static extern void cpBodyUpdatePosition(IntPtr body, double dt);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyLocalToWorld")]
        public static extern Vect cpBodyLocalToWorld(IntPtr body, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyWorldToLocal")]
        public static extern Vect cpBodyWorldToLocal(IntPtr body, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyForceAtWorldPoint")]
        public static extern void cpBodyApplyForceAtWorldPoint(IntPtr body, Vect force, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyForceAtLocalPoint")]
        public static extern void cpBodyApplyForceAtLocalPoint(IntPtr body, Vect force, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyImpulseAtWorldPoint")]
        public static extern void cpBodyApplyImpulseAtWorldPoint(IntPtr body, Vect impulse, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyImpulseAtLocalPoint")]
        public static extern void cpBodyApplyImpulseAtLocalPoint(IntPtr body, Vect impulse, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetVelocityAtWorldPoint")]
        public static extern Vect cpBodyGetVelocityAtWorldPoint(IntPtr body, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetVelocityAtLocalPoint")]
        public static extern Vect cpBodyGetVelocityAtLocalPoint(IntPtr body, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyKineticEnergy")]
        public static extern double cpBodyKineticEnergy(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintDestroy")]
        public static extern void cpConstraintDestroy(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintFree")]
        public static extern void cpConstraintFree(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetSpace")]
        public static extern IntPtr cpConstraintGetSpace(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetBodyA")]
        public static extern IntPtr cpConstraintGetBodyA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetBodyB")]
        public static extern IntPtr cpConstraintGetBodyB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetMaxForce")]
        public static extern double cpConstraintGetMaxForce(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetMaxForce")]
        public static extern void cpConstraintSetMaxForce(IntPtr constraint, double maxForce);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetErrorBias")]
        public static extern double cpConstraintGetErrorBias(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetErrorBias")]
        public static extern void cpConstraintSetErrorBias(IntPtr constraint, double errorBias);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetMaxBias")]
        public static extern double cpConstraintGetMaxBias(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetMaxBias")]
        public static extern void cpConstraintSetMaxBias(IntPtr constraint, double maxBias);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetCollideBodies")]
        public static extern bool cpConstraintGetCollideBodies(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetCollideBodies")]
        public static extern void cpConstraintSetCollideBodies(IntPtr constraint, bool collideBodies);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetUserData")]
        public static extern IntPtr cpConstraintGetUserData(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetUserData")]
        public static extern void cpConstraintSetUserData(IntPtr constraint, IntPtr userData);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetImpulse")]
        public static extern double cpConstraintGetImpulse(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsDampedRotarySpring")]
        public static extern bool cpConstraintIsDampedRotarySpring(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringAlloc")]
        public static extern IntPtr cpDampedRotarySpringAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringInit")]
        public static extern IntPtr cpDampedRotarySpringInit(IntPtr joint, IntPtr a, IntPtr b, double restAngle, double stiffness, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringNew")]
        public static extern IntPtr cpDampedRotarySpringNew(IntPtr a, IntPtr b, double restAngle, double stiffness, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringGetRestAngle")]
        public static extern double cpDampedRotarySpringGetRestAngle(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringSetRestAngle")]
        public static extern void cpDampedRotarySpringSetRestAngle(IntPtr constraint, double restAngle);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringGetStiffness")]
        public static extern double cpDampedRotarySpringGetStiffness(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringSetStiffness")]
        public static extern void cpDampedRotarySpringSetStiffness(IntPtr constraint, double stiffness);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringGetDamping")]
        public static extern double cpDampedRotarySpringGetDamping(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringSetDamping")]
        public static extern void cpDampedRotarySpringSetDamping(IntPtr constraint, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsDampedSpring")]
        public static extern bool cpConstraintIsDampedSpring(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringAlloc")]
        public static extern IntPtr cpDampedSpringAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringInit")]
        public static extern IntPtr cpDampedSpringInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double restLength, double stiffness, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringNew")]
        public static extern IntPtr cpDampedSpringNew(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double restLength, double stiffness, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetAnchorA")]
        public static extern Vect cpDampedSpringGetAnchorA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetAnchorA")]
        public static extern void cpDampedSpringSetAnchorA(IntPtr constraint, Vect anchorA);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetAnchorB")]
        public static extern Vect cpDampedSpringGetAnchorB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetAnchorB")]
        public static extern void cpDampedSpringSetAnchorB(IntPtr constraint, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetRestLength")]
        public static extern double cpDampedSpringGetRestLength(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetRestLength")]
        public static extern void cpDampedSpringSetRestLength(IntPtr constraint, double restLength);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetStiffness")]
        public static extern double cpDampedSpringGetStiffness(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetStiffness")]
        public static extern void cpDampedSpringSetStiffness(IntPtr constraint, double stiffness);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetDamping")]
        public static extern double cpDampedSpringGetDamping(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetDamping")]
        public static extern void cpDampedSpringSetDamping(IntPtr constraint, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsGearJoint")]
        public static extern bool cpConstraintIsGearJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointAlloc")]
        public static extern IntPtr cpGearJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointInit")]
        public static extern IntPtr cpGearJointInit(IntPtr joint, IntPtr a, IntPtr b, double phase, double ratio);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointNew")]
        public static extern IntPtr cpGearJointNew(IntPtr a, IntPtr b, double phase, double ratio);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointGetPhase")]
        public static extern double cpGearJointGetPhase(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointSetPhase")]
        public static extern void cpGearJointSetPhase(IntPtr constraint, double phase);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointGetRatio")]
        public static extern double cpGearJointGetRatio(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointSetRatio")]
        public static extern void cpGearJointSetRatio(IntPtr constraint, double ratio);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsGrooveJoint")]
        public static extern bool cpConstraintIsGrooveJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointAlloc")]
        public static extern IntPtr cpGrooveJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointInit")]
        public static extern IntPtr cpGrooveJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect groove_a, Vect groove_b, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointNew")]
        public static extern IntPtr cpGrooveJointNew(IntPtr a, IntPtr b, Vect groove_a, Vect groove_b, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointGetGrooveA")]
        public static extern Vect cpGrooveJointGetGrooveA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointSetGrooveA")]
        public static extern void cpGrooveJointSetGrooveA(IntPtr constraint, Vect grooveA);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointGetGrooveB")]
        public static extern Vect cpGrooveJointGetGrooveB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointSetGrooveB")]
        public static extern void cpGrooveJointSetGrooveB(IntPtr constraint, Vect grooveB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointGetAnchorB")]
        public static extern Vect cpGrooveJointGetAnchorB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointSetAnchorB")]
        public static extern void cpGrooveJointSetAnchorB(IntPtr constraint, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceNew")]
        public static extern IntPtr cpHastySpaceNew();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceFree")]
        public static extern void cpHastySpaceFree(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceSetThreads")]
        public static extern void cpHastySpaceSetThreads(IntPtr space, UInt64 threads);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceStep")]
        public static extern void cpHastySpaceStep(IntPtr space, double dt);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsPinJoint")]
        public static extern bool cpConstraintIsPinJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointAlloc")]
        public static extern IntPtr cpPinJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointInit")]
        public static extern IntPtr cpPinJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointNew")]
        public static extern IntPtr cpPinJointNew(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointGetAnchorA")]
        public static extern Vect cpPinJointGetAnchorA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointSetAnchorA")]
        public static extern void cpPinJointSetAnchorA(IntPtr constraint, Vect anchorA);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointGetAnchorB")]
        public static extern Vect cpPinJointGetAnchorB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointSetAnchorB")]
        public static extern void cpPinJointSetAnchorB(IntPtr constraint, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointGetDist")]
        public static extern double cpPinJointGetDist(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointSetDist")]
        public static extern void cpPinJointSetDist(IntPtr constraint, double dist);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsPivotJoint")]
        public static extern bool cpConstraintIsPivotJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointAlloc")]
        public static extern IntPtr cpPivotJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointInit")]
        public static extern IntPtr cpPivotJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointNew")]
        public static extern IntPtr cpPivotJointNew(IntPtr a, IntPtr b, Vect pivot);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointNew2")]
        public static extern IntPtr cpPivotJointNew2(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointGetAnchorA")]
        public static extern Vect cpPivotJointGetAnchorA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointSetAnchorA")]
        public static extern void cpPivotJointSetAnchorA(IntPtr constraint, Vect anchorA);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointGetAnchorB")]
        public static extern Vect cpPivotJointGetAnchorB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointSetAnchorB")]
        public static extern void cpPivotJointSetAnchorB(IntPtr constraint, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineFree")]
        public static extern void cpPolylineFree(IntPtr line);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineIsClosed")]
        public static extern bool cpPolylineIsClosed(IntPtr line);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSimplifyCurves")]
        public static extern IntPtr cpPolylineSimplifyCurves(IntPtr line, double tol);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSimplifyVertexes")]
        public static extern IntPtr cpPolylineSimplifyVertexes(IntPtr line, double tol);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineToConvexHull")]
        public static extern IntPtr cpPolylineToConvexHull(IntPtr line, double tol);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetAlloc")]
        public static extern IntPtr cpPolylineSetAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetInit")]
        public static extern IntPtr cpPolylineSetInit(IntPtr set);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetNew")]
        public static extern IntPtr cpPolylineSetNew();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetDestroy")]
        public static extern void cpPolylineSetDestroy(IntPtr set, bool freePolylines);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetFree")]
        public static extern void cpPolylineSetFree(IntPtr set, bool freePolylines);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetCollectSegment")]
        public static extern void cpPolylineSetCollectSegment(Vect v0, Vect v1, IntPtr lines);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineConvexDecomposition")]
        public static extern IntPtr cpPolylineConvexDecomposition(IntPtr line, double tol);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeAlloc")]
        public static extern IntPtr cpPolyShapeAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeInitRaw")]
        public static extern IntPtr cpPolyShapeInitRaw(IntPtr poly, IntPtr body, int count, IntPtr verts, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeNewRaw")]
        public static extern IntPtr cpPolyShapeNewRaw(IntPtr body, int count, IntPtr verts, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeInit")]
        public static extern IntPtr cpBoxShapeInit(IntPtr poly, IntPtr body, double width, double height, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeInit2")]
        public static extern IntPtr cpBoxShapeInit2(IntPtr poly, IntPtr body, BB box, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeNew")]
        public static extern IntPtr cpBoxShapeNew(IntPtr body, double width, double height, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeNew2")]
        public static extern IntPtr cpBoxShapeNew2(IntPtr body, BB box, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeGetCount")]
        public static extern int cpPolyShapeGetCount(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeGetVert")]
        public static extern Vect cpPolyShapeGetVert(IntPtr shape, int index);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeGetRadius")]
        public static extern double cpPolyShapeGetRadius(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsRatchetJoint")]
        public static extern bool cpConstraintIsRatchetJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointAlloc")]
        public static extern IntPtr cpRatchetJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointInit")]
        public static extern IntPtr cpRatchetJointInit(IntPtr joint, IntPtr a, IntPtr b, double phase, double ratchet);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointNew")]
        public static extern IntPtr cpRatchetJointNew(IntPtr a, IntPtr b, double phase, double ratchet);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointGetAngle")]
        public static extern double cpRatchetJointGetAngle(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointSetAngle")]
        public static extern void cpRatchetJointSetAngle(IntPtr constraint, double angle);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointGetPhase")]
        public static extern double cpRatchetJointGetPhase(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointSetPhase")]
        public static extern void cpRatchetJointSetPhase(IntPtr constraint, double phase);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointGetRatchet")]
        public static extern double cpRatchetJointGetRatchet(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointSetRatchet")]
        public static extern void cpRatchetJointSetRatchet(IntPtr constraint, double ratchet);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsRotaryLimitJoint")]
        public static extern bool cpConstraintIsRotaryLimitJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointAlloc")]
        public static extern IntPtr cpRotaryLimitJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointInit")]
        public static extern IntPtr cpRotaryLimitJointInit(IntPtr joint, IntPtr a, IntPtr b, double min, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointNew")]
        public static extern IntPtr cpRotaryLimitJointNew(IntPtr a, IntPtr b, double min, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointGetMin")]
        public static extern double cpRotaryLimitJointGetMin(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointSetMin")]
        public static extern void cpRotaryLimitJointSetMin(IntPtr constraint, double min);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointGetMax")]
        public static extern double cpRotaryLimitJointGetMax(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointSetMax")]
        public static extern void cpRotaryLimitJointSetMax(IntPtr constraint, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeDestroy")]
        public static extern void cpShapeDestroy(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeFree")]
        public static extern void cpShapeFree(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeCacheBB")]
        public static extern BB cpShapeCacheBB(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapePointQuery")]
        public static extern double cpShapePointQuery(IntPtr shape, Vect p, IntPtr output);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSegmentQuery")]
        public static extern bool cpShapeSegmentQuery(IntPtr shape, Vect a, Vect b, double radius, IntPtr info);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetSpace")]
        public static extern IntPtr cpShapeGetSpace(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetBody")]
        public static extern IntPtr cpShapeGetBody(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetBody")]
        public static extern void cpShapeSetBody(IntPtr shape, IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetMass")]
        public static extern double cpShapeGetMass(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetMass")]
        public static extern void cpShapeSetMass(IntPtr shape, double mass);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetDensity")]
        public static extern double cpShapeGetDensity(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetDensity")]
        public static extern void cpShapeSetDensity(IntPtr shape, double density);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetMoment")]
        public static extern double cpShapeGetMoment(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetArea")]
        public static extern double cpShapeGetArea(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetCenterOfGravity")]
        public static extern Vect cpShapeGetCenterOfGravity(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetBB")]
        public static extern BB cpShapeGetBB(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetSensor")]
        public static extern bool cpShapeGetSensor(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetSensor")]
        public static extern void cpShapeSetSensor(IntPtr shape, bool sensor);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetElasticity")]
        public static extern double cpShapeGetElasticity(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetElasticity")]
        public static extern void cpShapeSetElasticity(IntPtr shape, double elasticity);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetFriction")]
        public static extern double cpShapeGetFriction(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetFriction")]
        public static extern void cpShapeSetFriction(IntPtr shape, double friction);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetSurfaceVelocity")]
        public static extern Vect cpShapeGetSurfaceVelocity(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetSurfaceVelocity")]
        public static extern void cpShapeSetSurfaceVelocity(IntPtr shape, Vect surfaceVelocity);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetUserData")]
        public static extern IntPtr cpShapeGetUserData(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetUserData")]
        public static extern void cpShapeSetUserData(IntPtr shape, IntPtr userData);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeAlloc")]
        public static extern IntPtr cpCircleShapeAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeInit")]
        public static extern IntPtr cpCircleShapeInit(IntPtr circle, IntPtr body, double radius, Vect offset);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeNew")]
        public static extern IntPtr cpCircleShapeNew(IntPtr body, double radius, Vect offset);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeGetOffset")]
        public static extern Vect cpCircleShapeGetOffset(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeGetRadius")]
        public static extern double cpCircleShapeGetRadius(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeAlloc")]
        public static extern IntPtr cpSegmentShapeAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeInit")]
        public static extern IntPtr cpSegmentShapeInit(IntPtr seg, IntPtr body, Vect a, Vect b, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeNew")]
        public static extern IntPtr cpSegmentShapeNew(IntPtr body, Vect a, Vect b, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeSetNeighbors")]
        public static extern void cpSegmentShapeSetNeighbors(IntPtr shape, Vect prev, Vect next);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetA")]
        public static extern Vect cpSegmentShapeGetA(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetB")]
        public static extern Vect cpSegmentShapeGetB(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetNormal")]
        public static extern Vect cpSegmentShapeGetNormal(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetRadius")]
        public static extern double cpSegmentShapeGetRadius(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsSimpleMotor")]
        public static extern bool cpConstraintIsSimpleMotor(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorAlloc")]
        public static extern IntPtr cpSimpleMotorAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorInit")]
        public static extern IntPtr cpSimpleMotorInit(IntPtr joint, IntPtr a, IntPtr b, double rate);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorNew")]
        public static extern IntPtr cpSimpleMotorNew(IntPtr a, IntPtr b, double rate);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorGetRate")]
        public static extern double cpSimpleMotorGetRate(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorSetRate")]
        public static extern void cpSimpleMotorSetRate(IntPtr constraint, double rate);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsSlideJoint")]
        public static extern bool cpConstraintIsSlideJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointAlloc")]
        public static extern IntPtr cpSlideJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointInit")]
        public static extern IntPtr cpSlideJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double min, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointNew")]
        public static extern IntPtr cpSlideJointNew(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double min, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetAnchorA")]
        public static extern Vect cpSlideJointGetAnchorA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetAnchorA")]
        public static extern void cpSlideJointSetAnchorA(IntPtr constraint, Vect anchorA);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetAnchorB")]
        public static extern Vect cpSlideJointGetAnchorB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetAnchorB")]
        public static extern void cpSlideJointSetAnchorB(IntPtr constraint, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetMin")]
        public static extern double cpSlideJointGetMin(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetMin")]
        public static extern void cpSlideJointSetMin(IntPtr constraint, double min);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetMax")]
        public static extern double cpSlideJointGetMax(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetMax")]
        public static extern void cpSlideJointSetMax(IntPtr constraint, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAlloc")]
        public static extern IntPtr cpSpaceAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceInit")]
        public static extern IntPtr cpSpaceInit(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceNew")]
        public static extern IntPtr cpSpaceNew();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceDestroy")]
        public static extern void cpSpaceDestroy(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceFree")]
        public static extern void cpSpaceFree(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetIterations")]
        public static extern int cpSpaceGetIterations(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetIterations")]
        public static extern void cpSpaceSetIterations(IntPtr space, int iterations);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetGravity")]
        public static extern Vect cpSpaceGetGravity(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetGravity")]
        public static extern void cpSpaceSetGravity(IntPtr space, Vect gravity);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetDamping")]
        public static extern double cpSpaceGetDamping(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetDamping")]
        public static extern void cpSpaceSetDamping(IntPtr space, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetIdleSpeedThreshold")]
        public static extern double cpSpaceGetIdleSpeedThreshold(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetIdleSpeedThreshold")]
        public static extern void cpSpaceSetIdleSpeedThreshold(IntPtr space, double idleSpeedThreshold);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetSleepTimeThreshold")]
        public static extern double cpSpaceGetSleepTimeThreshold(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetSleepTimeThreshold")]
        public static extern void cpSpaceSetSleepTimeThreshold(IntPtr space, double sleepTimeThreshold);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetCollisionSlop")]
        public static extern double cpSpaceGetCollisionSlop(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetCollisionSlop")]
        public static extern void cpSpaceSetCollisionSlop(IntPtr space, double collisionSlop);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetCollisionBias")]
        public static extern double cpSpaceGetCollisionBias(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetCollisionBias")]
        public static extern void cpSpaceSetCollisionBias(IntPtr space, double collisionBias);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetUserData")]
        public static extern IntPtr cpSpaceGetUserData(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetUserData")]
        public static extern void cpSpaceSetUserData(IntPtr space, IntPtr userData);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetStaticBody")]
        public static extern IntPtr cpSpaceGetStaticBody(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetCurrentTimeStep")]
        public static extern double cpSpaceGetCurrentTimeStep(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceIsLocked")]
        public static extern bool cpSpaceIsLocked(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddDefaultCollisionHandler")]
        public static extern IntPtr cpSpaceAddDefaultCollisionHandler(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddShape")]
        public static extern IntPtr cpSpaceAddShape(IntPtr space, IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddBody")]
        public static extern IntPtr cpSpaceAddBody(IntPtr space, IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddConstraint")]
        public static extern IntPtr cpSpaceAddConstraint(IntPtr space, IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceRemoveShape")]
        public static extern void cpSpaceRemoveShape(IntPtr space, IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceRemoveBody")]
        public static extern void cpSpaceRemoveBody(IntPtr space, IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceRemoveConstraint")]
        public static extern void cpSpaceRemoveConstraint(IntPtr space, IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceContainsShape")]
        public static extern bool cpSpaceContainsShape(IntPtr space, IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceContainsBody")]
        public static extern bool cpSpaceContainsBody(IntPtr space, IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceContainsConstraint")]
        public static extern bool cpSpaceContainsConstraint(IntPtr space, IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceReindexStatic")]
        public static extern void cpSpaceReindexStatic(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceReindexShape")]
        public static extern void cpSpaceReindexShape(IntPtr space, IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceReindexShapesForBody")]
        public static extern void cpSpaceReindexShapesForBody(IntPtr space, IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceUseSpatialHash")]
        public static extern void cpSpaceUseSpatialHash(IntPtr space, double dim, int count);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceStep")]
        public static extern void cpSpaceStep(IntPtr space, double dt);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceDebugDraw")]
        public static extern void cpSpaceDebugDraw(IntPtr space, IntPtr options);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceHashAlloc")]
        public static extern IntPtr cpSpaceHashAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceHashResize")]
        public static extern void cpSpaceHashResize(IntPtr hash, double celldim, int numcells);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBBTreeAlloc")]
        public static extern IntPtr cpBBTreeAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBBTreeOptimize")]
        public static extern void cpBBTreeOptimize(IntPtr index);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSweep1DAlloc")]
        public static extern IntPtr cpSweep1DAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpatialIndexFree")]
        public static extern void cpSpatialIndexFree(IntPtr index);

    }
}

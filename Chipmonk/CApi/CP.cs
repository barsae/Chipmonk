using System;
using System.Runtime.InteropServices;

namespace Chipmonk {
    public static class CP {
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardBeginA")]
        public static extern bool ArbiterCallWildcardBeginA(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardBeginB")]
        public static extern bool ArbiterCallWildcardBeginB(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPostSolveA")]
        public static extern void ArbiterCallWildcardPostSolveA(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPostSolveB")]
        public static extern void ArbiterCallWildcardPostSolveB(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPreSolveA")]
        public static extern bool ArbiterCallWildcardPreSolveA(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPreSolveB")]
        public static extern bool ArbiterCallWildcardPreSolveB(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardSeparateA")]
        public static extern void ArbiterCallWildcardSeparateA(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardSeparateB")]
        public static extern void ArbiterCallWildcardSeparateB(IntPtr arb, IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetBodies")]
        public static extern void ArbiterGetBodies(IntPtr arb, IntPtr a, IntPtr b);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetCount")]
        public static extern int ArbiterGetCount(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetDepth")]
        public static extern double ArbiterGetDepth(IntPtr arb, int i);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetFriction")]
        public static extern double ArbiterGetFriction(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetNormal")]
        public static extern Vect ArbiterGetNormal(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetPointA")]
        public static extern Vect ArbiterGetPointA(IntPtr arb, int i);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetPointB")]
        public static extern Vect ArbiterGetPointB(IntPtr arb, int i);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetRestitution")]
        public static extern double ArbiterGetRestitution(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetShapes")]
        public static extern void ArbiterGetShapes(IntPtr arb, IntPtr a, IntPtr b);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetSurfaceVelocity")]
        public static extern Vect ArbiterGetSurfaceVelocity(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetUserData")]
        public static extern IntPtr ArbiterGetUserData(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterIgnore")]
        public static extern bool ArbiterIgnore(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterIsFirstContact")]
        public static extern bool ArbiterIsFirstContact(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterIsRemoval")]
        public static extern bool ArbiterIsRemoval(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetContactPointSet")]
        public static extern void ArbiterSetContactPointSet(IntPtr arb, IntPtr set);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetFriction")]
        public static extern void ArbiterSetFriction(IntPtr arb, double friction);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetRestitution")]
        public static extern void ArbiterSetRestitution(IntPtr arb, double restitution);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetSurfaceVelocity")]
        public static extern void ArbiterSetSurfaceVelocity(IntPtr arb, Vect vr);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetUserData")]
        public static extern void ArbiterSetUserData(IntPtr arb, IntPtr userData);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterTotalImpulse")]
        public static extern Vect ArbiterTotalImpulse(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterTotalKE")]
        public static extern double ArbiterTotalKE(IntPtr arb);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpAreaForCircle")]
        public static extern double AreaForCircle(double r1, double r2);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpAreaForPoly")]
        public static extern double AreaForPoly(int count, IntPtr verts, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpAreaForSegment")]
        public static extern double AreaForSegment(Vect a, Vect b, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBBTreeAlloc")]
        public static extern IntPtr BBTreeAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBBTreeOptimize")]
        public static extern void BBTreeOptimize(IntPtr index);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyActivate")]
        public static extern void BodyActivate(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyActivateStatic")]
        public static extern void BodyActivateStatic(IntPtr body, IntPtr filter);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyAlloc")]
        public static extern IntPtr BodyAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyForceAtLocalPoint")]
        public static extern void BodyApplyForceAtLocalPoint(IntPtr body, Vect force, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyForceAtWorldPoint")]
        public static extern void BodyApplyForceAtWorldPoint(IntPtr body, Vect force, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyImpulseAtLocalPoint")]
        public static extern void BodyApplyImpulseAtLocalPoint(IntPtr body, Vect impulse, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyImpulseAtWorldPoint")]
        public static extern void BodyApplyImpulseAtWorldPoint(IntPtr body, Vect impulse, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyDestroy")]
        public static extern void BodyDestroy(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyFree")]
        public static extern void BodyFree(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetAngle")]
        public static extern double BodyGetAngle(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetAngularVelocity")]
        public static extern double BodyGetAngularVelocity(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetCenterOfGravity")]
        public static extern Vect BodyGetCenterOfGravity(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetForce")]
        public static extern Vect BodyGetForce(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetMass")]
        public static extern double BodyGetMass(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetMoment")]
        public static extern double BodyGetMoment(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetPosition")]
        public static extern Vect BodyGetPosition(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetRotation")]
        public static extern Vect BodyGetRotation(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetSpace")]
        public static extern IntPtr BodyGetSpace(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetTorque")]
        public static extern double BodyGetTorque(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetType")]
        public static extern BodyType BodyGetType(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetUserData")]
        public static extern IntPtr BodyGetUserData(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetVelocity")]
        public static extern Vect BodyGetVelocity(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetVelocityAtLocalPoint")]
        public static extern Vect BodyGetVelocityAtLocalPoint(IntPtr body, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetVelocityAtWorldPoint")]
        public static extern Vect BodyGetVelocityAtWorldPoint(IntPtr body, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyInit")]
        public static extern IntPtr BodyInit(IntPtr body, double mass, double moment);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyIsSleeping")]
        public static extern bool BodyIsSleeping(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyKineticEnergy")]
        public static extern double BodyKineticEnergy(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyLocalToWorld")]
        public static extern Vect BodyLocalToWorld(IntPtr body, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyNew")]
        public static extern IntPtr BodyNew(double mass, double moment);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyNewKinematic")]
        public static extern IntPtr BodyNewKinematic();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyNewStatic")]
        public static extern IntPtr BodyNewStatic();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetAngle")]
        public static extern void BodySetAngle(IntPtr body, double a);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetAngularVelocity")]
        public static extern void BodySetAngularVelocity(IntPtr body, double angularVelocity);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetCenterOfGravity")]
        public static extern void BodySetCenterOfGravity(IntPtr body, Vect cog);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetForce")]
        public static extern void BodySetForce(IntPtr body, Vect force);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetMass")]
        public static extern void BodySetMass(IntPtr body, double m);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetMoment")]
        public static extern void BodySetMoment(IntPtr body, double i);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetPosition")]
        public static extern void BodySetPosition(IntPtr body, Vect pos);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetTorque")]
        public static extern void BodySetTorque(IntPtr body, double torque);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetType")]
        public static extern void BodySetType(IntPtr body, BodyType type);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetUserData")]
        public static extern void BodySetUserData(IntPtr body, IntPtr userData);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetVelocity")]
        public static extern void BodySetVelocity(IntPtr body, Vect velocity);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySleep")]
        public static extern void BodySleep(IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySleepWithGroup")]
        public static extern void BodySleepWithGroup(IntPtr body, IntPtr group);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyUpdatePosition")]
        public static extern void BodyUpdatePosition(IntPtr body, double dt);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyUpdateVelocity")]
        public static extern void BodyUpdateVelocity(IntPtr body, Vect gravity, double damping, double dt);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyWorldToLocal")]
        public static extern Vect BodyWorldToLocal(IntPtr body, Vect point);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeInit")]
        public static extern IntPtr BoxShapeInit(IntPtr poly, IntPtr body, double width, double height, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeInit2")]
        public static extern IntPtr BoxShapeInit2(IntPtr poly, IntPtr body, BB box, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeNew")]
        public static extern IntPtr BoxShapeNew(IntPtr body, double width, double height, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeNew2")]
        public static extern IntPtr BoxShapeNew2(IntPtr body, BB box, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCentroidForPoly")]
        public static extern Vect CentroidForPoly(int count, IntPtr verts);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeAlloc")]
        public static extern IntPtr CircleShapeAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeGetOffset")]
        public static extern Vect CircleShapeGetOffset(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeGetRadius")]
        public static extern double CircleShapeGetRadius(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeInit")]
        public static extern IntPtr CircleShapeInit(IntPtr circle, IntPtr body, double radius, Vect offset);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeNew")]
        public static extern IntPtr CircleShapeNew(IntPtr body, double radius, Vect offset);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeSetOffset")]
        public static extern void CircleShapeSetOffset(IntPtr shape, Vect offset);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeSetRadius")]
        public static extern void CircleShapeSetRadius(IntPtr shape, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintDestroy")]
        public static extern void ConstraintDestroy(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintFree")]
        public static extern void ConstraintFree(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetBodyA")]
        public static extern IntPtr ConstraintGetBodyA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetBodyB")]
        public static extern IntPtr ConstraintGetBodyB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetCollideBodies")]
        public static extern bool ConstraintGetCollideBodies(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetErrorBias")]
        public static extern double ConstraintGetErrorBias(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetImpulse")]
        public static extern double ConstraintGetImpulse(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetMaxBias")]
        public static extern double ConstraintGetMaxBias(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetMaxForce")]
        public static extern double ConstraintGetMaxForce(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetSpace")]
        public static extern IntPtr ConstraintGetSpace(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetUserData")]
        public static extern IntPtr ConstraintGetUserData(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsDampedRotarySpring")]
        public static extern bool ConstraintIsDampedRotarySpring(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsDampedSpring")]
        public static extern bool ConstraintIsDampedSpring(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsGearJoint")]
        public static extern bool ConstraintIsGearJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsGrooveJoint")]
        public static extern bool ConstraintIsGrooveJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsPinJoint")]
        public static extern bool ConstraintIsPinJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsPivotJoint")]
        public static extern bool ConstraintIsPivotJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsRatchetJoint")]
        public static extern bool ConstraintIsRatchetJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsRotaryLimitJoint")]
        public static extern bool ConstraintIsRotaryLimitJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsSimpleMotor")]
        public static extern bool ConstraintIsSimpleMotor(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsSlideJoint")]
        public static extern bool ConstraintIsSlideJoint(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetCollideBodies")]
        public static extern void ConstraintSetCollideBodies(IntPtr constraint, bool collideBodies);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetErrorBias")]
        public static extern void ConstraintSetErrorBias(IntPtr constraint, double errorBias);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetMaxBias")]
        public static extern void ConstraintSetMaxBias(IntPtr constraint, double maxBias);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetMaxForce")]
        public static extern void ConstraintSetMaxForce(IntPtr constraint, double maxForce);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetUserData")]
        public static extern void ConstraintSetUserData(IntPtr constraint, IntPtr userData);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConvexHull")]
        public static extern int ConvexHull(int count, IntPtr verts, IntPtr result, IntPtr first, double tol);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringAlloc")]
        public static extern IntPtr DampedRotarySpringAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringGetDamping")]
        public static extern double DampedRotarySpringGetDamping(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringGetRestAngle")]
        public static extern double DampedRotarySpringGetRestAngle(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringGetStiffness")]
        public static extern double DampedRotarySpringGetStiffness(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringInit")]
        public static extern IntPtr DampedRotarySpringInit(IntPtr joint, IntPtr a, IntPtr b, double restAngle, double stiffness, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringNew")]
        public static extern IntPtr DampedRotarySpringNew(IntPtr a, IntPtr b, double restAngle, double stiffness, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringSetDamping")]
        public static extern void DampedRotarySpringSetDamping(IntPtr constraint, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringSetRestAngle")]
        public static extern void DampedRotarySpringSetRestAngle(IntPtr constraint, double restAngle);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringSetStiffness")]
        public static extern void DampedRotarySpringSetStiffness(IntPtr constraint, double stiffness);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringAlloc")]
        public static extern IntPtr DampedSpringAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetAnchorA")]
        public static extern Vect DampedSpringGetAnchorA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetAnchorB")]
        public static extern Vect DampedSpringGetAnchorB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetDamping")]
        public static extern double DampedSpringGetDamping(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetRestLength")]
        public static extern double DampedSpringGetRestLength(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetStiffness")]
        public static extern double DampedSpringGetStiffness(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringInit")]
        public static extern IntPtr DampedSpringInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double restLength, double stiffness, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringNew")]
        public static extern IntPtr DampedSpringNew(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double restLength, double stiffness, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetAnchorA")]
        public static extern void DampedSpringSetAnchorA(IntPtr constraint, Vect anchorA);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetAnchorB")]
        public static extern void DampedSpringSetAnchorB(IntPtr constraint, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetDamping")]
        public static extern void DampedSpringSetDamping(IntPtr constraint, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetRestLength")]
        public static extern void DampedSpringSetRestLength(IntPtr constraint, double restLength);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetStiffness")]
        public static extern void DampedSpringSetStiffness(IntPtr constraint, double stiffness);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointAlloc")]
        public static extern IntPtr GearJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointGetPhase")]
        public static extern double GearJointGetPhase(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointGetRatio")]
        public static extern double GearJointGetRatio(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointInit")]
        public static extern IntPtr GearJointInit(IntPtr joint, IntPtr a, IntPtr b, double phase, double ratio);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointNew")]
        public static extern IntPtr GearJointNew(IntPtr a, IntPtr b, double phase, double ratio);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointSetPhase")]
        public static extern void GearJointSetPhase(IntPtr constraint, double phase);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointSetRatio")]
        public static extern void GearJointSetRatio(IntPtr constraint, double ratio);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointAlloc")]
        public static extern IntPtr GrooveJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointGetAnchorB")]
        public static extern Vect GrooveJointGetAnchorB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointGetGrooveA")]
        public static extern Vect GrooveJointGetGrooveA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointGetGrooveB")]
        public static extern Vect GrooveJointGetGrooveB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointInit")]
        public static extern IntPtr GrooveJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect groove_a, Vect groove_b, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointNew")]
        public static extern IntPtr GrooveJointNew(IntPtr a, IntPtr b, Vect groove_a, Vect groove_b, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointSetAnchorB")]
        public static extern void GrooveJointSetAnchorB(IntPtr constraint, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointSetGrooveA")]
        public static extern void GrooveJointSetGrooveA(IntPtr constraint, Vect grooveA);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointSetGrooveB")]
        public static extern void GrooveJointSetGrooveB(IntPtr constraint, Vect grooveB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceFree")]
        public static extern void HastySpaceFree(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceNew")]
        public static extern IntPtr HastySpaceNew();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceSetThreads")]
        public static extern void HastySpaceSetThreads(IntPtr space, UInt64 threads);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceStep")]
        public static extern void HastySpaceStep(IntPtr space, double dt);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMessage")]
        public static extern void Message(IntPtr condition, IntPtr file, int line, int isError, int isHardError, IntPtr message, params object[] varargs);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForBox")]
        public static extern double MomentForBox(double m, double width, double height);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForBox2")]
        public static extern double MomentForBox2(double m, BB box);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForCircle")]
        public static extern double MomentForCircle(double m, double r1, double r2, Vect offset);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForPoly")]
        public static extern double MomentForPoly(double m, int count, IntPtr verts, Vect offset, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForSegment")]
        public static extern double MomentForSegment(double m, Vect a, Vect b, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointAlloc")]
        public static extern IntPtr PinJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointGetAnchorA")]
        public static extern Vect PinJointGetAnchorA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointGetAnchorB")]
        public static extern Vect PinJointGetAnchorB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointGetDist")]
        public static extern double PinJointGetDist(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointInit")]
        public static extern IntPtr PinJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointNew")]
        public static extern IntPtr PinJointNew(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointSetAnchorA")]
        public static extern void PinJointSetAnchorA(IntPtr constraint, Vect anchorA);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointSetAnchorB")]
        public static extern void PinJointSetAnchorB(IntPtr constraint, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointSetDist")]
        public static extern void PinJointSetDist(IntPtr constraint, double dist);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointAlloc")]
        public static extern IntPtr PivotJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointGetAnchorA")]
        public static extern Vect PivotJointGetAnchorA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointGetAnchorB")]
        public static extern Vect PivotJointGetAnchorB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointInit")]
        public static extern IntPtr PivotJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointNew")]
        public static extern IntPtr PivotJointNew(IntPtr a, IntPtr b, Vect pivot);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointNew2")]
        public static extern IntPtr PivotJointNew2(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointSetAnchorA")]
        public static extern void PivotJointSetAnchorA(IntPtr constraint, Vect anchorA);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointSetAnchorB")]
        public static extern void PivotJointSetAnchorB(IntPtr constraint, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineConvexDecomposition")]
        public static extern IntPtr PolylineConvexDecomposition(IntPtr line, double tol);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineFree")]
        public static extern void PolylineFree(IntPtr line);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineIsClosed")]
        public static extern bool PolylineIsClosed(IntPtr line);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetAlloc")]
        public static extern IntPtr PolylineSetAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetCollectSegment")]
        public static extern void PolylineSetCollectSegment(Vect v0, Vect v1, IntPtr lines);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetDestroy")]
        public static extern void PolylineSetDestroy(IntPtr set, bool freePolylines);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetFree")]
        public static extern void PolylineSetFree(IntPtr set, bool freePolylines);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetInit")]
        public static extern IntPtr PolylineSetInit(IntPtr set);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetNew")]
        public static extern IntPtr PolylineSetNew();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSimplifyCurves")]
        public static extern IntPtr PolylineSimplifyCurves(IntPtr line, double tol);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSimplifyVertexes")]
        public static extern IntPtr PolylineSimplifyVertexes(IntPtr line, double tol);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineToConvexHull")]
        public static extern IntPtr PolylineToConvexHull(IntPtr line, double tol);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeAlloc")]
        public static extern IntPtr PolyShapeAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeGetCount")]
        public static extern int PolyShapeGetCount(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeGetRadius")]
        public static extern double PolyShapeGetRadius(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeGetVert")]
        public static extern Vect PolyShapeGetVert(IntPtr shape, int index);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeInitRaw")]
        public static extern IntPtr PolyShapeInitRaw(IntPtr poly, IntPtr body, int count, IntPtr verts, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeNewRaw")]
        public static extern IntPtr PolyShapeNewRaw(IntPtr body, int count, IntPtr verts, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeSetRadius")]
        public static extern void PolyShapeSetRadius(IntPtr shape, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeSetVertsRaw")]
        public static extern void PolyShapeSetVertsRaw(IntPtr shape, int count, IntPtr verts);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointAlloc")]
        public static extern IntPtr RatchetJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointGetAngle")]
        public static extern double RatchetJointGetAngle(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointGetPhase")]
        public static extern double RatchetJointGetPhase(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointGetRatchet")]
        public static extern double RatchetJointGetRatchet(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointInit")]
        public static extern IntPtr RatchetJointInit(IntPtr joint, IntPtr a, IntPtr b, double phase, double ratchet);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointNew")]
        public static extern IntPtr RatchetJointNew(IntPtr a, IntPtr b, double phase, double ratchet);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointSetAngle")]
        public static extern void RatchetJointSetAngle(IntPtr constraint, double angle);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointSetPhase")]
        public static extern void RatchetJointSetPhase(IntPtr constraint, double phase);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointSetRatchet")]
        public static extern void RatchetJointSetRatchet(IntPtr constraint, double ratchet);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointAlloc")]
        public static extern IntPtr RotaryLimitJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointGetMax")]
        public static extern double RotaryLimitJointGetMax(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointGetMin")]
        public static extern double RotaryLimitJointGetMin(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointInit")]
        public static extern IntPtr RotaryLimitJointInit(IntPtr joint, IntPtr a, IntPtr b, double min, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointNew")]
        public static extern IntPtr RotaryLimitJointNew(IntPtr a, IntPtr b, double min, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointSetMax")]
        public static extern void RotaryLimitJointSetMax(IntPtr constraint, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointSetMin")]
        public static extern void RotaryLimitJointSetMin(IntPtr constraint, double min);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeAlloc")]
        public static extern IntPtr SegmentShapeAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetA")]
        public static extern Vect SegmentShapeGetA(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetB")]
        public static extern Vect SegmentShapeGetB(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetNormal")]
        public static extern Vect SegmentShapeGetNormal(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetRadius")]
        public static extern double SegmentShapeGetRadius(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeInit")]
        public static extern IntPtr SegmentShapeInit(IntPtr seg, IntPtr body, Vect a, Vect b, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeNew")]
        public static extern IntPtr SegmentShapeNew(IntPtr body, Vect a, Vect b, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeSetEndpoints")]
        public static extern void SegmentShapeSetEndpoints(IntPtr shape, Vect a, Vect b);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeSetNeighbors")]
        public static extern void SegmentShapeSetNeighbors(IntPtr shape, Vect prev, Vect next);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeSetRadius")]
        public static extern void SegmentShapeSetRadius(IntPtr shape, double radius);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeCacheBB")]
        public static extern BB ShapeCacheBB(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeDestroy")]
        public static extern void ShapeDestroy(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeFree")]
        public static extern void ShapeFree(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetArea")]
        public static extern double ShapeGetArea(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetBB")]
        public static extern BB ShapeGetBB(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetBody")]
        public static extern IntPtr ShapeGetBody(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetCenterOfGravity")]
        public static extern Vect ShapeGetCenterOfGravity(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetDensity")]
        public static extern double ShapeGetDensity(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetElasticity")]
        public static extern double ShapeGetElasticity(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetFriction")]
        public static extern double ShapeGetFriction(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetMass")]
        public static extern double ShapeGetMass(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetMoment")]
        public static extern double ShapeGetMoment(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetSensor")]
        public static extern bool ShapeGetSensor(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetSpace")]
        public static extern IntPtr ShapeGetSpace(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetSurfaceVelocity")]
        public static extern Vect ShapeGetSurfaceVelocity(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetUserData")]
        public static extern IntPtr ShapeGetUserData(IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapePointQuery")]
        public static extern double ShapePointQuery(IntPtr shape, Vect p, IntPtr output);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSegmentQuery")]
        public static extern bool ShapeSegmentQuery(IntPtr shape, Vect a, Vect b, double radius, IntPtr info);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetBody")]
        public static extern void ShapeSetBody(IntPtr shape, IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetDensity")]
        public static extern void ShapeSetDensity(IntPtr shape, double density);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetElasticity")]
        public static extern void ShapeSetElasticity(IntPtr shape, double elasticity);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetFriction")]
        public static extern void ShapeSetFriction(IntPtr shape, double friction);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetMass")]
        public static extern void ShapeSetMass(IntPtr shape, double mass);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetSensor")]
        public static extern void ShapeSetSensor(IntPtr shape, bool sensor);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetSurfaceVelocity")]
        public static extern void ShapeSetSurfaceVelocity(IntPtr shape, Vect surfaceVelocity);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetUserData")]
        public static extern void ShapeSetUserData(IntPtr shape, IntPtr userData);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorAlloc")]
        public static extern IntPtr SimpleMotorAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorGetRate")]
        public static extern double SimpleMotorGetRate(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorInit")]
        public static extern IntPtr SimpleMotorInit(IntPtr joint, IntPtr a, IntPtr b, double rate);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorNew")]
        public static extern IntPtr SimpleMotorNew(IntPtr a, IntPtr b, double rate);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorSetRate")]
        public static extern void SimpleMotorSetRate(IntPtr constraint, double rate);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointAlloc")]
        public static extern IntPtr SlideJointAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetAnchorA")]
        public static extern Vect SlideJointGetAnchorA(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetAnchorB")]
        public static extern Vect SlideJointGetAnchorB(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetMax")]
        public static extern double SlideJointGetMax(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetMin")]
        public static extern double SlideJointGetMin(IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointInit")]
        public static extern IntPtr SlideJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double min, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointNew")]
        public static extern IntPtr SlideJointNew(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double min, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetAnchorA")]
        public static extern void SlideJointSetAnchorA(IntPtr constraint, Vect anchorA);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetAnchorB")]
        public static extern void SlideJointSetAnchorB(IntPtr constraint, Vect anchorB);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetMax")]
        public static extern void SlideJointSetMax(IntPtr constraint, double max);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetMin")]
        public static extern void SlideJointSetMin(IntPtr constraint, double min);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddBody")]
        public static extern IntPtr SpaceAddBody(IntPtr space, IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddConstraint")]
        public static extern IntPtr SpaceAddConstraint(IntPtr space, IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddDefaultCollisionHandler")]
        public static extern IntPtr SpaceAddDefaultCollisionHandler(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddShape")]
        public static extern IntPtr SpaceAddShape(IntPtr space, IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAlloc")]
        public static extern IntPtr SpaceAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceContainsBody")]
        public static extern bool SpaceContainsBody(IntPtr space, IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceContainsConstraint")]
        public static extern bool SpaceContainsConstraint(IntPtr space, IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceContainsShape")]
        public static extern bool SpaceContainsShape(IntPtr space, IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceDebugDraw")]
        public static extern void SpaceDebugDraw(IntPtr space, IntPtr options);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceDestroy")]
        public static extern void SpaceDestroy(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceFree")]
        public static extern void SpaceFree(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetCollisionBias")]
        public static extern double SpaceGetCollisionBias(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetCollisionSlop")]
        public static extern double SpaceGetCollisionSlop(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetCurrentTimeStep")]
        public static extern double SpaceGetCurrentTimeStep(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetDamping")]
        public static extern double SpaceGetDamping(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetGravity")]
        public static extern Vect SpaceGetGravity(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetIdleSpeedThreshold")]
        public static extern double SpaceGetIdleSpeedThreshold(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetIterations")]
        public static extern int SpaceGetIterations(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetSleepTimeThreshold")]
        public static extern double SpaceGetSleepTimeThreshold(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetStaticBody")]
        public static extern IntPtr SpaceGetStaticBody(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetUserData")]
        public static extern IntPtr SpaceGetUserData(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceHashAlloc")]
        public static extern IntPtr SpaceHashAlloc();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceHashResize")]
        public static extern void SpaceHashResize(IntPtr hash, double celldim, int numcells);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceInit")]
        public static extern IntPtr SpaceInit(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceIsLocked")]
        public static extern bool SpaceIsLocked(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceNew")]
        public static extern IntPtr SpaceNew();

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceReindexShape")]
        public static extern void SpaceReindexShape(IntPtr space, IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceReindexShapesForBody")]
        public static extern void SpaceReindexShapesForBody(IntPtr space, IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceReindexStatic")]
        public static extern void SpaceReindexStatic(IntPtr space);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceRemoveBody")]
        public static extern void SpaceRemoveBody(IntPtr space, IntPtr body);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceRemoveConstraint")]
        public static extern void SpaceRemoveConstraint(IntPtr space, IntPtr constraint);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceRemoveShape")]
        public static extern void SpaceRemoveShape(IntPtr space, IntPtr shape);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetCollisionBias")]
        public static extern void SpaceSetCollisionBias(IntPtr space, double collisionBias);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetCollisionSlop")]
        public static extern void SpaceSetCollisionSlop(IntPtr space, double collisionSlop);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetDamping")]
        public static extern void SpaceSetDamping(IntPtr space, double damping);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetGravity")]
        public static extern void SpaceSetGravity(IntPtr space, Vect gravity);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetIdleSpeedThreshold")]
        public static extern void SpaceSetIdleSpeedThreshold(IntPtr space, double idleSpeedThreshold);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetIterations")]
        public static extern void SpaceSetIterations(IntPtr space, int iterations);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetSleepTimeThreshold")]
        public static extern void SpaceSetSleepTimeThreshold(IntPtr space, double sleepTimeThreshold);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetUserData")]
        public static extern void SpaceSetUserData(IntPtr space, IntPtr userData);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceStep")]
        public static extern void SpaceStep(IntPtr space, double dt);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceUseSpatialHash")]
        public static extern void SpaceUseSpatialHash(IntPtr space, double dim, int count);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpatialIndexFree")]
        public static extern void SpatialIndexFree(IntPtr index);

        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSweep1DAlloc")]
        public static extern IntPtr Sweep1DAlloc();

    }
}

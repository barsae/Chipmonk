using System;
using System.Runtime.InteropServices;

namespace Chipmonk.CApi {
    public static class CP {
        // CP_EXPORT cpBool cpArbiterCallWildcardBeginA(cpArbiter *arb, cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardBeginA")]
        public static extern bool ArbiterCallWildcardBeginA(IntPtr arb, IntPtr space);

        // CP_EXPORT cpBool cpArbiterCallWildcardBeginB(cpArbiter *arb, cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardBeginB")]
        public static extern bool ArbiterCallWildcardBeginB(IntPtr arb, IntPtr space);

        // CP_EXPORT void cpArbiterCallWildcardPostSolveA(cpArbiter *arb, cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPostSolveA")]
        public static extern void ArbiterCallWildcardPostSolveA(IntPtr arb, IntPtr space);

        // CP_EXPORT void cpArbiterCallWildcardPostSolveB(cpArbiter *arb, cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPostSolveB")]
        public static extern void ArbiterCallWildcardPostSolveB(IntPtr arb, IntPtr space);

        // CP_EXPORT cpBool cpArbiterCallWildcardPreSolveA(cpArbiter *arb, cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPreSolveA")]
        public static extern bool ArbiterCallWildcardPreSolveA(IntPtr arb, IntPtr space);

        // CP_EXPORT cpBool cpArbiterCallWildcardPreSolveB(cpArbiter *arb, cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardPreSolveB")]
        public static extern bool ArbiterCallWildcardPreSolveB(IntPtr arb, IntPtr space);

        // CP_EXPORT void cpArbiterCallWildcardSeparateA(cpArbiter *arb, cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardSeparateA")]
        public static extern void ArbiterCallWildcardSeparateA(IntPtr arb, IntPtr space);

        // CP_EXPORT void cpArbiterCallWildcardSeparateB(cpArbiter *arb, cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterCallWildcardSeparateB")]
        public static extern void ArbiterCallWildcardSeparateB(IntPtr arb, IntPtr space);

        // CP_EXPORT void cpArbiterGetBodies(const cpArbiter *arb, cpBody **a, cpBody **b);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetBodies")]
        public static extern void ArbiterGetBodies(IntPtr arb, IntPtr a, IntPtr b);

        // CP_EXPORT cpContactPointSet cpArbiterGetContactPointSet(const cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetContactPointSet")]
        public static extern ContactPointSet ArbiterGetContactPointSet(IntPtr arb);

        // CP_EXPORT int cpArbiterGetCount(const cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetCount")]
        public static extern int ArbiterGetCount(IntPtr arb);

        // CP_EXPORT cpFloat cpArbiterGetDepth(const cpArbiter *arb, int i);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetDepth")]
        public static extern double ArbiterGetDepth(IntPtr arb, int i);

        // CP_EXPORT cpFloat cpArbiterGetFriction(const cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetFriction")]
        public static extern double ArbiterGetFriction(IntPtr arb);

        // CP_EXPORT cpVect cpArbiterGetNormal(const cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetNormal")]
        public static extern Vect ArbiterGetNormal(IntPtr arb);

        // CP_EXPORT cpVect cpArbiterGetPointA(const cpArbiter *arb, int i);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetPointA")]
        public static extern Vect ArbiterGetPointA(IntPtr arb, int i);

        // CP_EXPORT cpVect cpArbiterGetPointB(const cpArbiter *arb, int i);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetPointB")]
        public static extern Vect ArbiterGetPointB(IntPtr arb, int i);

        // CP_EXPORT cpFloat cpArbiterGetRestitution(const cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetRestitution")]
        public static extern double ArbiterGetRestitution(IntPtr arb);

        // CP_EXPORT void cpArbiterGetShapes(const cpArbiter *arb, cpShape **a, cpShape **b);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetShapes")]
        public static extern void ArbiterGetShapes(IntPtr arb, IntPtr a, IntPtr b);

        // CP_EXPORT cpVect cpArbiterGetSurfaceVelocity(cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetSurfaceVelocity")]
        public static extern Vect ArbiterGetSurfaceVelocity(IntPtr arb);

        // CP_EXPORT cpDataPointer cpArbiterGetUserData(const cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterGetUserData")]
        public static extern IntPtr ArbiterGetUserData(IntPtr arb);

        // CP_EXPORT cpBool cpArbiterIgnore(cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterIgnore")]
        public static extern bool ArbiterIgnore(IntPtr arb);

        // CP_EXPORT cpBool cpArbiterIsFirstContact(const cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterIsFirstContact")]
        public static extern bool ArbiterIsFirstContact(IntPtr arb);

        // CP_EXPORT cpBool cpArbiterIsRemoval(const cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterIsRemoval")]
        public static extern bool ArbiterIsRemoval(IntPtr arb);

        // CP_EXPORT void cpArbiterSetContactPointSet(cpArbiter *arb, cpContactPointSet *set);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetContactPointSet")]
        public static extern void ArbiterSetContactPointSet(IntPtr arb, IntPtr set);

        // CP_EXPORT void cpArbiterSetFriction(cpArbiter *arb, cpFloat friction);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetFriction")]
        public static extern void ArbiterSetFriction(IntPtr arb, double friction);

        // CP_EXPORT void cpArbiterSetRestitution(cpArbiter *arb, cpFloat restitution);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetRestitution")]
        public static extern void ArbiterSetRestitution(IntPtr arb, double restitution);

        // CP_EXPORT void cpArbiterSetSurfaceVelocity(cpArbiter *arb, cpVect vr);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetSurfaceVelocity")]
        public static extern void ArbiterSetSurfaceVelocity(IntPtr arb, Vect vr);

        // CP_EXPORT void cpArbiterSetUserData(cpArbiter *arb, cpDataPointer userData);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterSetUserData")]
        public static extern void ArbiterSetUserData(IntPtr arb, IntPtr userData);

        // CP_EXPORT cpVect cpArbiterTotalImpulse(const cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterTotalImpulse")]
        public static extern Vect ArbiterTotalImpulse(IntPtr arb);

        // CP_EXPORT cpFloat cpArbiterTotalKE(const cpArbiter *arb);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpArbiterTotalKE")]
        public static extern double ArbiterTotalKE(IntPtr arb);

        // CP_EXPORT cpFloat cpAreaForCircle(cpFloat r1, cpFloat r2);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpAreaForCircle")]
        public static extern double AreaForCircle(double r1, double r2);

        // CP_EXPORT cpFloat cpAreaForPoly(const int count, const cpVect *verts, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpAreaForPoly")]
        public static extern double AreaForPoly(int count, IntPtr verts, double radius);

        // CP_EXPORT cpFloat cpAreaForSegment(cpVect a, cpVect b, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpAreaForSegment")]
        public static extern double AreaForSegment(Vect a, Vect b, double radius);

        // CP_EXPORT cpBBTree* cpBBTreeAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBBTreeAlloc")]
        public static extern IntPtr BBTreeAlloc();

        // CP_EXPORT cpSpatialIndex* cpBBTreeInit(cpBBTree *tree, cpSpatialIndexBBFunc bbfunc, cpSpatialIndex *staticIndex);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBBTreeInit")]
        public static extern IntPtr BBTreeInit(IntPtr tree, IntPtr bbfunc, IntPtr staticIndex);

        // CP_EXPORT cpSpatialIndex* cpBBTreeNew(cpSpatialIndexBBFunc bbfunc, cpSpatialIndex *staticIndex);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBBTreeNew")]
        public static extern IntPtr BBTreeNew(IntPtr bbfunc, IntPtr staticIndex);

        // CP_EXPORT void cpBBTreeOptimize(cpSpatialIndex *index);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBBTreeOptimize")]
        public static extern void BBTreeOptimize(IntPtr index);

        // CP_EXPORT void cpBBTreeSetVelocityFunc(cpSpatialIndex *index, cpBBTreeVelocityFunc func);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBBTreeSetVelocityFunc")]
        public static extern void BBTreeSetVelocityFunc(IntPtr index, IntPtr func);

        // CP_EXPORT void cpBodyActivate(cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyActivate")]
        public static extern void BodyActivate(IntPtr body);

        // CP_EXPORT void cpBodyActivateStatic(cpBody *body, cpShape *filter);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyActivateStatic")]
        public static extern void BodyActivateStatic(IntPtr body, IntPtr filter);

        // CP_EXPORT cpBody* cpBodyAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyAlloc")]
        public static extern IntPtr BodyAlloc();

        // CP_EXPORT void cpBodyApplyForceAtLocalPoint(cpBody *body, cpVect force, cpVect point);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyForceAtLocalPoint")]
        public static extern void BodyApplyForceAtLocalPoint(IntPtr body, Vect force, Vect point);

        // CP_EXPORT void cpBodyApplyForceAtWorldPoint(cpBody *body, cpVect force, cpVect point);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyForceAtWorldPoint")]
        public static extern void BodyApplyForceAtWorldPoint(IntPtr body, Vect force, Vect point);

        // CP_EXPORT void cpBodyApplyImpulseAtLocalPoint(cpBody *body, cpVect impulse, cpVect point);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyImpulseAtLocalPoint")]
        public static extern void BodyApplyImpulseAtLocalPoint(IntPtr body, Vect impulse, Vect point);

        // CP_EXPORT void cpBodyApplyImpulseAtWorldPoint(cpBody *body, cpVect impulse, cpVect point);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyApplyImpulseAtWorldPoint")]
        public static extern void BodyApplyImpulseAtWorldPoint(IntPtr body, Vect impulse, Vect point);

        // CP_EXPORT void cpBodyDestroy(cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyDestroy")]
        public static extern void BodyDestroy(IntPtr body);

        // CP_EXPORT void cpBodyEachArbiter(cpBody *body, cpBodyArbiterIteratorFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyEachArbiter")]
        public static extern void BodyEachArbiter(IntPtr body, IntPtr func, IntPtr data);

        // CP_EXPORT void cpBodyEachConstraint(cpBody *body, cpBodyConstraintIteratorFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyEachConstraint")]
        public static extern void BodyEachConstraint(IntPtr body, IntPtr func, IntPtr data);

        // CP_EXPORT void cpBodyEachShape(cpBody *body, cpBodyShapeIteratorFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyEachShape")]
        public static extern void BodyEachShape(IntPtr body, IntPtr func, IntPtr data);

        // CP_EXPORT void cpBodyFree(cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyFree")]
        public static extern void BodyFree(IntPtr body);

        // CP_EXPORT cpFloat cpBodyGetAngle(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetAngle")]
        public static extern double BodyGetAngle(IntPtr body);

        // CP_EXPORT cpFloat cpBodyGetAngularVelocity(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetAngularVelocity")]
        public static extern double BodyGetAngularVelocity(IntPtr body);

        // CP_EXPORT cpVect cpBodyGetCenterOfGravity(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetCenterOfGravity")]
        public static extern Vect BodyGetCenterOfGravity(IntPtr body);

        // CP_EXPORT cpVect cpBodyGetForce(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetForce")]
        public static extern Vect BodyGetForce(IntPtr body);

        // CP_EXPORT cpFloat cpBodyGetMass(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetMass")]
        public static extern double BodyGetMass(IntPtr body);

        // CP_EXPORT cpFloat cpBodyGetMoment(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetMoment")]
        public static extern double BodyGetMoment(IntPtr body);

        // CP_EXPORT cpVect cpBodyGetPosition(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetPosition")]
        public static extern Vect BodyGetPosition(IntPtr body);

        // CP_EXPORT cpVect cpBodyGetRotation(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetRotation")]
        public static extern Vect BodyGetRotation(IntPtr body);

        // CP_EXPORT cpSpace* cpBodyGetSpace(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetSpace")]
        public static extern IntPtr BodyGetSpace(IntPtr body);

        // CP_EXPORT cpFloat cpBodyGetTorque(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetTorque")]
        public static extern double BodyGetTorque(IntPtr body);

        // CP_EXPORT cpBodyType cpBodyGetType(cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetType")]
        public static extern BodyType BodyGetType(IntPtr body);

        // CP_EXPORT cpDataPointer cpBodyGetUserData(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetUserData")]
        public static extern IntPtr BodyGetUserData(IntPtr body);

        // CP_EXPORT cpVect cpBodyGetVelocity(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetVelocity")]
        public static extern Vect BodyGetVelocity(IntPtr body);

        // CP_EXPORT cpVect cpBodyGetVelocityAtLocalPoint(const cpBody *body, cpVect point);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetVelocityAtLocalPoint")]
        public static extern Vect BodyGetVelocityAtLocalPoint(IntPtr body, Vect point);

        // CP_EXPORT cpVect cpBodyGetVelocityAtWorldPoint(const cpBody *body, cpVect point);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyGetVelocityAtWorldPoint")]
        public static extern Vect BodyGetVelocityAtWorldPoint(IntPtr body, Vect point);

        // CP_EXPORT cpBody* cpBodyInit(cpBody *body, cpFloat mass, cpFloat moment);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyInit")]
        public static extern IntPtr BodyInit(IntPtr body, double mass, double moment);

        // CP_EXPORT cpBool cpBodyIsSleeping(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyIsSleeping")]
        public static extern bool BodyIsSleeping(IntPtr body);

        // CP_EXPORT cpFloat cpBodyKineticEnergy(const cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyKineticEnergy")]
        public static extern double BodyKineticEnergy(IntPtr body);

        // CP_EXPORT cpVect cpBodyLocalToWorld(const cpBody *body, const cpVect point);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyLocalToWorld")]
        public static extern Vect BodyLocalToWorld(IntPtr body, Vect point);

        // CP_EXPORT cpBody* cpBodyNew(cpFloat mass, cpFloat moment);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyNew")]
        public static extern IntPtr BodyNew(double mass, double moment);

        // CP_EXPORT cpBody* cpBodyNewKinematic(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyNewKinematic")]
        public static extern IntPtr BodyNewKinematic();

        // CP_EXPORT cpBody* cpBodyNewStatic(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyNewStatic")]
        public static extern IntPtr BodyNewStatic();

        // CP_EXPORT void cpBodySetAngle(cpBody *body, cpFloat a);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetAngle")]
        public static extern void BodySetAngle(IntPtr body, double a);

        // CP_EXPORT void cpBodySetAngularVelocity(cpBody *body, cpFloat angularVelocity);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetAngularVelocity")]
        public static extern void BodySetAngularVelocity(IntPtr body, double angularVelocity);

        // CP_EXPORT void cpBodySetCenterOfGravity(cpBody *body, cpVect cog);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetCenterOfGravity")]
        public static extern void BodySetCenterOfGravity(IntPtr body, Vect cog);

        // CP_EXPORT void cpBodySetForce(cpBody *body, cpVect force);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetForce")]
        public static extern void BodySetForce(IntPtr body, Vect force);

        // CP_EXPORT void cpBodySetMass(cpBody *body, cpFloat m);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetMass")]
        public static extern void BodySetMass(IntPtr body, double m);

        // CP_EXPORT void cpBodySetMoment(cpBody *body, cpFloat i);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetMoment")]
        public static extern void BodySetMoment(IntPtr body, double i);

        // CP_EXPORT void cpBodySetPosition(cpBody *body, cpVect pos);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetPosition")]
        public static extern void BodySetPosition(IntPtr body, Vect pos);

        // CP_EXPORT void cpBodySetPositionUpdateFunc(cpBody *body, cpBodyPositionFunc positionFunc);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetPositionUpdateFunc")]
        public static extern void BodySetPositionUpdateFunc(IntPtr body, IntPtr positionFunc);

        // CP_EXPORT void cpBodySetTorque(cpBody *body, cpFloat torque);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetTorque")]
        public static extern void BodySetTorque(IntPtr body, double torque);

        // CP_EXPORT void cpBodySetType(cpBody *body, cpBodyType type);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetType")]
        public static extern void BodySetType(IntPtr body, BodyType type);

        // CP_EXPORT void cpBodySetUserData(cpBody *body, cpDataPointer userData);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetUserData")]
        public static extern void BodySetUserData(IntPtr body, IntPtr userData);

        // CP_EXPORT void cpBodySetVelocity(cpBody *body, cpVect velocity);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetVelocity")]
        public static extern void BodySetVelocity(IntPtr body, Vect velocity);

        // CP_EXPORT void cpBodySetVelocityUpdateFunc(cpBody *body, cpBodyVelocityFunc velocityFunc);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySetVelocityUpdateFunc")]
        public static extern void BodySetVelocityUpdateFunc(IntPtr body, IntPtr velocityFunc);

        // CP_EXPORT void cpBodySleep(cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySleep")]
        public static extern void BodySleep(IntPtr body);

        // CP_EXPORT void cpBodySleepWithGroup(cpBody *body, cpBody *group);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodySleepWithGroup")]
        public static extern void BodySleepWithGroup(IntPtr body, IntPtr group);

        // CP_EXPORT void cpBodyUpdatePosition(cpBody *body, cpFloat dt);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyUpdatePosition")]
        public static extern void BodyUpdatePosition(IntPtr body, double dt);

        // CP_EXPORT void cpBodyUpdateVelocity(cpBody *body, cpVect gravity, cpFloat damping, cpFloat dt);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyUpdateVelocity")]
        public static extern void BodyUpdateVelocity(IntPtr body, Vect gravity, double damping, double dt);

        // CP_EXPORT cpVect cpBodyWorldToLocal(const cpBody *body, const cpVect point);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBodyWorldToLocal")]
        public static extern Vect BodyWorldToLocal(IntPtr body, Vect point);

        // CP_EXPORT cpPolyShape* cpBoxShapeInit(cpPolyShape *poly, cpBody *body, cpFloat width, cpFloat height, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeInit")]
        public static extern IntPtr BoxShapeInit(IntPtr poly, IntPtr body, double width, double height, double radius);

        // CP_EXPORT cpPolyShape* cpBoxShapeInit2(cpPolyShape *poly, cpBody *body, cpBB box, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeInit2")]
        public static extern IntPtr BoxShapeInit2(IntPtr poly, IntPtr body, BB box, double radius);

        // CP_EXPORT cpShape* cpBoxShapeNew(cpBody *body, cpFloat width, cpFloat height, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeNew")]
        public static extern IntPtr BoxShapeNew(IntPtr body, double width, double height, double radius);

        // CP_EXPORT cpShape* cpBoxShapeNew2(cpBody *body, cpBB box, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpBoxShapeNew2")]
        public static extern IntPtr BoxShapeNew2(IntPtr body, BB box, double radius);

        // CP_EXPORT cpVect cpCentroidForPoly(const int count, const cpVect *verts);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCentroidForPoly")]
        public static extern Vect CentroidForPoly(int count, IntPtr verts);

        // CP_EXPORT cpCircleShape* cpCircleShapeAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeAlloc")]
        public static extern IntPtr CircleShapeAlloc();

        // CP_EXPORT cpVect cpCircleShapeGetOffset(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeGetOffset")]
        public static extern Vect CircleShapeGetOffset(IntPtr shape);

        // CP_EXPORT cpFloat cpCircleShapeGetRadius(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeGetRadius")]
        public static extern double CircleShapeGetRadius(IntPtr shape);

        // CP_EXPORT cpCircleShape* cpCircleShapeInit(cpCircleShape *circle, cpBody *body, cpFloat radius, cpVect offset);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeInit")]
        public static extern IntPtr CircleShapeInit(IntPtr circle, IntPtr body, double radius, Vect offset);

        // CP_EXPORT cpShape* cpCircleShapeNew(cpBody *body, cpFloat radius, cpVect offset);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeNew")]
        public static extern IntPtr CircleShapeNew(IntPtr body, double radius, Vect offset);

        // CP_EXPORT void cpCircleShapeSetOffset(cpShape *shape, cpVect offset);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeSetOffset")]
        public static extern void CircleShapeSetOffset(IntPtr shape, Vect offset);

        // CP_EXPORT void cpCircleShapeSetRadius(cpShape *shape, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCircleShapeSetRadius")]
        public static extern void CircleShapeSetRadius(IntPtr shape, double radius);

        // CP_EXPORT void cpConstraintDestroy(cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintDestroy")]
        public static extern void ConstraintDestroy(IntPtr constraint);

        // CP_EXPORT void cpConstraintFree(cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintFree")]
        public static extern void ConstraintFree(IntPtr constraint);

        // CP_EXPORT cpBody* cpConstraintGetBodyA(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetBodyA")]
        public static extern IntPtr ConstraintGetBodyA(IntPtr constraint);

        // CP_EXPORT cpBody* cpConstraintGetBodyB(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetBodyB")]
        public static extern IntPtr ConstraintGetBodyB(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintGetCollideBodies(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetCollideBodies")]
        public static extern bool ConstraintGetCollideBodies(IntPtr constraint);

        // CP_EXPORT cpFloat cpConstraintGetErrorBias(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetErrorBias")]
        public static extern double ConstraintGetErrorBias(IntPtr constraint);

        // CP_EXPORT cpFloat cpConstraintGetImpulse(cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetImpulse")]
        public static extern double ConstraintGetImpulse(IntPtr constraint);

        // CP_EXPORT cpFloat cpConstraintGetMaxBias(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetMaxBias")]
        public static extern double ConstraintGetMaxBias(IntPtr constraint);

        // CP_EXPORT cpFloat cpConstraintGetMaxForce(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetMaxForce")]
        public static extern double ConstraintGetMaxForce(IntPtr constraint);

        // CP_EXPORT cpConstraintPostSolveFunc cpConstraintGetPostSolveFunc(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetPostSolveFunc")]
        public static extern IntPtr ConstraintGetPostSolveFunc(IntPtr constraint);

        // CP_EXPORT cpConstraintPreSolveFunc cpConstraintGetPreSolveFunc(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetPreSolveFunc")]
        public static extern IntPtr ConstraintGetPreSolveFunc(IntPtr constraint);

        // CP_EXPORT cpSpace* cpConstraintGetSpace(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetSpace")]
        public static extern IntPtr ConstraintGetSpace(IntPtr constraint);

        // CP_EXPORT cpDataPointer cpConstraintGetUserData(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintGetUserData")]
        public static extern IntPtr ConstraintGetUserData(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintIsDampedRotarySpring(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsDampedRotarySpring")]
        public static extern bool ConstraintIsDampedRotarySpring(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintIsDampedSpring(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsDampedSpring")]
        public static extern bool ConstraintIsDampedSpring(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintIsGearJoint(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsGearJoint")]
        public static extern bool ConstraintIsGearJoint(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintIsGrooveJoint(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsGrooveJoint")]
        public static extern bool ConstraintIsGrooveJoint(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintIsPinJoint(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsPinJoint")]
        public static extern bool ConstraintIsPinJoint(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintIsPivotJoint(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsPivotJoint")]
        public static extern bool ConstraintIsPivotJoint(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintIsRatchetJoint(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsRatchetJoint")]
        public static extern bool ConstraintIsRatchetJoint(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintIsRotaryLimitJoint(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsRotaryLimitJoint")]
        public static extern bool ConstraintIsRotaryLimitJoint(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintIsSimpleMotor(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsSimpleMotor")]
        public static extern bool ConstraintIsSimpleMotor(IntPtr constraint);

        // CP_EXPORT cpBool cpConstraintIsSlideJoint(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintIsSlideJoint")]
        public static extern bool ConstraintIsSlideJoint(IntPtr constraint);

        // CP_EXPORT void cpConstraintSetCollideBodies(cpConstraint *constraint, cpBool collideBodies);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetCollideBodies")]
        public static extern void ConstraintSetCollideBodies(IntPtr constraint, bool collideBodies);

        // CP_EXPORT void cpConstraintSetErrorBias(cpConstraint *constraint, cpFloat errorBias);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetErrorBias")]
        public static extern void ConstraintSetErrorBias(IntPtr constraint, double errorBias);

        // CP_EXPORT void cpConstraintSetMaxBias(cpConstraint *constraint, cpFloat maxBias);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetMaxBias")]
        public static extern void ConstraintSetMaxBias(IntPtr constraint, double maxBias);

        // CP_EXPORT void cpConstraintSetMaxForce(cpConstraint *constraint, cpFloat maxForce);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetMaxForce")]
        public static extern void ConstraintSetMaxForce(IntPtr constraint, double maxForce);

        // CP_EXPORT void cpConstraintSetPostSolveFunc(cpConstraint *constraint, cpConstraintPostSolveFunc postSolveFunc);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetPostSolveFunc")]
        public static extern void ConstraintSetPostSolveFunc(IntPtr constraint, IntPtr postSolveFunc);

        // CP_EXPORT void cpConstraintSetPreSolveFunc(cpConstraint *constraint, cpConstraintPreSolveFunc preSolveFunc);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetPreSolveFunc")]
        public static extern void ConstraintSetPreSolveFunc(IntPtr constraint, IntPtr preSolveFunc);

        // CP_EXPORT void cpConstraintSetUserData(cpConstraint *constraint, cpDataPointer userData);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConstraintSetUserData")]
        public static extern void ConstraintSetUserData(IntPtr constraint, IntPtr userData);

        // CP_EXPORT int cpConvexHull(int count, const cpVect *verts, cpVect *result, int *first, cpFloat tol);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpConvexHull")]
        public static extern int ConvexHull(int count, IntPtr verts, IntPtr result, IntPtr first, double tol);

        // CP_EXPORT cpDampedRotarySpring* cpDampedRotarySpringAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringAlloc")]
        public static extern IntPtr DampedRotarySpringAlloc();

        // CP_EXPORT cpFloat cpDampedRotarySpringGetDamping(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringGetDamping")]
        public static extern double DampedRotarySpringGetDamping(IntPtr constraint);

        // CP_EXPORT cpFloat cpDampedRotarySpringGetRestAngle(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringGetRestAngle")]
        public static extern double DampedRotarySpringGetRestAngle(IntPtr constraint);

        // CP_EXPORT cpDampedRotarySpringTorqueFunc cpDampedRotarySpringGetSpringTorqueFunc(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringGetSpringTorqueFunc")]
        public static extern IntPtr DampedRotarySpringGetSpringTorqueFunc(IntPtr constraint);

        // CP_EXPORT cpFloat cpDampedRotarySpringGetStiffness(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringGetStiffness")]
        public static extern double DampedRotarySpringGetStiffness(IntPtr constraint);

        // CP_EXPORT cpDampedRotarySpring* cpDampedRotarySpringInit(cpDampedRotarySpring *joint, cpBody *a, cpBody *b, cpFloat restAngle, cpFloat stiffness, cpFloat damping);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringInit")]
        public static extern IntPtr DampedRotarySpringInit(IntPtr joint, IntPtr a, IntPtr b, double restAngle, double stiffness, double damping);

        // CP_EXPORT cpConstraint* cpDampedRotarySpringNew(cpBody *a, cpBody *b, cpFloat restAngle, cpFloat stiffness, cpFloat damping);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringNew")]
        public static extern IntPtr DampedRotarySpringNew(IntPtr a, IntPtr b, double restAngle, double stiffness, double damping);

        // CP_EXPORT void cpDampedRotarySpringSetDamping(cpConstraint *constraint, cpFloat damping);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringSetDamping")]
        public static extern void DampedRotarySpringSetDamping(IntPtr constraint, double damping);

        // CP_EXPORT void cpDampedRotarySpringSetRestAngle(cpConstraint *constraint, cpFloat restAngle);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringSetRestAngle")]
        public static extern void DampedRotarySpringSetRestAngle(IntPtr constraint, double restAngle);

        // CP_EXPORT void cpDampedRotarySpringSetSpringTorqueFunc(cpConstraint *constraint, cpDampedRotarySpringTorqueFunc springTorqueFunc);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringSetSpringTorqueFunc")]
        public static extern void DampedRotarySpringSetSpringTorqueFunc(IntPtr constraint, IntPtr springTorqueFunc);

        // CP_EXPORT void cpDampedRotarySpringSetStiffness(cpConstraint *constraint, cpFloat stiffness);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedRotarySpringSetStiffness")]
        public static extern void DampedRotarySpringSetStiffness(IntPtr constraint, double stiffness);

        // CP_EXPORT cpDampedSpring* cpDampedSpringAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringAlloc")]
        public static extern IntPtr DampedSpringAlloc();

        // CP_EXPORT cpVect cpDampedSpringGetAnchorA(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetAnchorA")]
        public static extern Vect DampedSpringGetAnchorA(IntPtr constraint);

        // CP_EXPORT cpVect cpDampedSpringGetAnchorB(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetAnchorB")]
        public static extern Vect DampedSpringGetAnchorB(IntPtr constraint);

        // CP_EXPORT cpFloat cpDampedSpringGetDamping(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetDamping")]
        public static extern double DampedSpringGetDamping(IntPtr constraint);

        // CP_EXPORT cpFloat cpDampedSpringGetRestLength(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetRestLength")]
        public static extern double DampedSpringGetRestLength(IntPtr constraint);

        // CP_EXPORT cpDampedSpringForceFunc cpDampedSpringGetSpringForceFunc(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetSpringForceFunc")]
        public static extern IntPtr DampedSpringGetSpringForceFunc(IntPtr constraint);

        // CP_EXPORT cpFloat cpDampedSpringGetStiffness(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringGetStiffness")]
        public static extern double DampedSpringGetStiffness(IntPtr constraint);

        // CP_EXPORT cpDampedSpring* cpDampedSpringInit(cpDampedSpring *joint, cpBody *a, cpBody *b, cpVect anchorA, cpVect anchorB, cpFloat restLength, cpFloat stiffness, cpFloat damping);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringInit")]
        public static extern IntPtr DampedSpringInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double restLength, double stiffness, double damping);

        // CP_EXPORT cpConstraint* cpDampedSpringNew(cpBody *a, cpBody *b, cpVect anchorA, cpVect anchorB, cpFloat restLength, cpFloat stiffness, cpFloat damping);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringNew")]
        public static extern IntPtr DampedSpringNew(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double restLength, double stiffness, double damping);

        // CP_EXPORT void cpDampedSpringSetAnchorA(cpConstraint *constraint, cpVect anchorA);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetAnchorA")]
        public static extern void DampedSpringSetAnchorA(IntPtr constraint, Vect anchorA);

        // CP_EXPORT void cpDampedSpringSetAnchorB(cpConstraint *constraint, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetAnchorB")]
        public static extern void DampedSpringSetAnchorB(IntPtr constraint, Vect anchorB);

        // CP_EXPORT void cpDampedSpringSetDamping(cpConstraint *constraint, cpFloat damping);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetDamping")]
        public static extern void DampedSpringSetDamping(IntPtr constraint, double damping);

        // CP_EXPORT void cpDampedSpringSetRestLength(cpConstraint *constraint, cpFloat restLength);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetRestLength")]
        public static extern void DampedSpringSetRestLength(IntPtr constraint, double restLength);

        // CP_EXPORT void cpDampedSpringSetSpringForceFunc(cpConstraint *constraint, cpDampedSpringForceFunc springForceFunc);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetSpringForceFunc")]
        public static extern void DampedSpringSetSpringForceFunc(IntPtr constraint, IntPtr springForceFunc);

        // CP_EXPORT void cpDampedSpringSetStiffness(cpConstraint *constraint, cpFloat stiffness);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpDampedSpringSetStiffness")]
        public static extern void DampedSpringSetStiffness(IntPtr constraint, double stiffness);

        // CP_EXPORT cpGearJoint* cpGearJointAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointAlloc")]
        public static extern IntPtr GearJointAlloc();

        // CP_EXPORT cpFloat cpGearJointGetPhase(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointGetPhase")]
        public static extern double GearJointGetPhase(IntPtr constraint);

        // CP_EXPORT cpFloat cpGearJointGetRatio(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointGetRatio")]
        public static extern double GearJointGetRatio(IntPtr constraint);

        // CP_EXPORT cpGearJoint* cpGearJointInit(cpGearJoint *joint, cpBody *a, cpBody *b, cpFloat phase, cpFloat ratio);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointInit")]
        public static extern IntPtr GearJointInit(IntPtr joint, IntPtr a, IntPtr b, double phase, double ratio);

        // CP_EXPORT cpConstraint* cpGearJointNew(cpBody *a, cpBody *b, cpFloat phase, cpFloat ratio);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointNew")]
        public static extern IntPtr GearJointNew(IntPtr a, IntPtr b, double phase, double ratio);

        // CP_EXPORT void cpGearJointSetPhase(cpConstraint *constraint, cpFloat phase);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointSetPhase")]
        public static extern void GearJointSetPhase(IntPtr constraint, double phase);

        // CP_EXPORT void cpGearJointSetRatio(cpConstraint *constraint, cpFloat ratio);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGearJointSetRatio")]
        public static extern void GearJointSetRatio(IntPtr constraint, double ratio);

        // CP_EXPORT cpGrooveJoint* cpGrooveJointAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointAlloc")]
        public static extern IntPtr GrooveJointAlloc();

        // CP_EXPORT cpVect cpGrooveJointGetAnchorB(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointGetAnchorB")]
        public static extern Vect GrooveJointGetAnchorB(IntPtr constraint);

        // CP_EXPORT cpVect cpGrooveJointGetGrooveA(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointGetGrooveA")]
        public static extern Vect GrooveJointGetGrooveA(IntPtr constraint);

        // CP_EXPORT cpVect cpGrooveJointGetGrooveB(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointGetGrooveB")]
        public static extern Vect GrooveJointGetGrooveB(IntPtr constraint);

        // CP_EXPORT cpGrooveJoint* cpGrooveJointInit(cpGrooveJoint *joint, cpBody *a, cpBody *b, cpVect groove_a, cpVect groove_b, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointInit")]
        public static extern IntPtr GrooveJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect groove_a, Vect groove_b, Vect anchorB);

        // CP_EXPORT cpConstraint* cpGrooveJointNew(cpBody *a, cpBody *b, cpVect groove_a, cpVect groove_b, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointNew")]
        public static extern IntPtr GrooveJointNew(IntPtr a, IntPtr b, Vect groove_a, Vect groove_b, Vect anchorB);

        // CP_EXPORT void cpGrooveJointSetAnchorB(cpConstraint *constraint, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointSetAnchorB")]
        public static extern void GrooveJointSetAnchorB(IntPtr constraint, Vect anchorB);

        // CP_EXPORT void cpGrooveJointSetGrooveA(cpConstraint *constraint, cpVect grooveA);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointSetGrooveA")]
        public static extern void GrooveJointSetGrooveA(IntPtr constraint, Vect grooveA);

        // CP_EXPORT void cpGrooveJointSetGrooveB(cpConstraint *constraint, cpVect grooveB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGrooveJointSetGrooveB")]
        public static extern void GrooveJointSetGrooveB(IntPtr constraint, Vect grooveB);

        // CP_EXPORT void cpHastySpaceFree(cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceFree")]
        public static extern void HastySpaceFree(IntPtr space);

        // CP_EXPORT cpSpace *cpHastySpaceNew(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceNew")]
        public static extern IntPtr HastySpaceNew();

        // CP_EXPORT void cpHastySpaceSetThreads(cpSpace *space, unsigned long threads);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceSetThreads")]
        public static extern void HastySpaceSetThreads(IntPtr space, ulong threads);

        // CP_EXPORT void cpHastySpaceStep(cpSpace *space, cpFloat dt);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpHastySpaceStep")]
        public static extern void HastySpaceStep(IntPtr space, double dt);

        // CP_EXPORT void cpMessage(const char *condition, const char *file, int line, int isError, int isHardError, const char *message, ...);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMessage")]
        public static extern void Message(IntPtr condition, IntPtr file, int line, int isError, int isHardError, IntPtr message, params object[] varargs);

        // CP_EXPORT cpFloat cpMomentForBox(cpFloat m, cpFloat width, cpFloat height);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForBox")]
        public static extern double MomentForBox(double m, double width, double height);

        // CP_EXPORT cpFloat cpMomentForBox2(cpFloat m, cpBB box);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForBox2")]
        public static extern double MomentForBox2(double m, BB box);

        // CP_EXPORT cpFloat cpMomentForCircle(cpFloat m, cpFloat r1, cpFloat r2, cpVect offset);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForCircle")]
        public static extern double MomentForCircle(double m, double r1, double r2, Vect offset);

        // CP_EXPORT cpFloat cpMomentForPoly(cpFloat m, int count, const cpVect *verts, cpVect offset, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForPoly")]
        public static extern double MomentForPoly(double m, int count, IntPtr verts, Vect offset, double radius);

        // CP_EXPORT cpFloat cpMomentForSegment(cpFloat m, cpVect a, cpVect b, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpMomentForSegment")]
        public static extern double MomentForSegment(double m, Vect a, Vect b, double radius);

        // CP_EXPORT cpPinJoint* cpPinJointAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointAlloc")]
        public static extern IntPtr PinJointAlloc();

        // CP_EXPORT cpVect cpPinJointGetAnchorA(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointGetAnchorA")]
        public static extern Vect PinJointGetAnchorA(IntPtr constraint);

        // CP_EXPORT cpVect cpPinJointGetAnchorB(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointGetAnchorB")]
        public static extern Vect PinJointGetAnchorB(IntPtr constraint);

        // CP_EXPORT cpFloat cpPinJointGetDist(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointGetDist")]
        public static extern double PinJointGetDist(IntPtr constraint);

        // CP_EXPORT cpPinJoint* cpPinJointInit(cpPinJoint *joint, cpBody *a, cpBody *b, cpVect anchorA, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointInit")]
        public static extern IntPtr PinJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        // CP_EXPORT cpConstraint* cpPinJointNew(cpBody *a, cpBody *b, cpVect anchorA, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointNew")]
        public static extern IntPtr PinJointNew(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        // CP_EXPORT void cpPinJointSetAnchorA(cpConstraint *constraint, cpVect anchorA);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointSetAnchorA")]
        public static extern void PinJointSetAnchorA(IntPtr constraint, Vect anchorA);

        // CP_EXPORT void cpPinJointSetAnchorB(cpConstraint *constraint, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointSetAnchorB")]
        public static extern void PinJointSetAnchorB(IntPtr constraint, Vect anchorB);

        // CP_EXPORT void cpPinJointSetDist(cpConstraint *constraint, cpFloat dist);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPinJointSetDist")]
        public static extern void PinJointSetDist(IntPtr constraint, double dist);

        // CP_EXPORT cpPivotJoint* cpPivotJointAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointAlloc")]
        public static extern IntPtr PivotJointAlloc();

        // CP_EXPORT cpVect cpPivotJointGetAnchorA(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointGetAnchorA")]
        public static extern Vect PivotJointGetAnchorA(IntPtr constraint);

        // CP_EXPORT cpVect cpPivotJointGetAnchorB(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointGetAnchorB")]
        public static extern Vect PivotJointGetAnchorB(IntPtr constraint);

        // CP_EXPORT cpPivotJoint* cpPivotJointInit(cpPivotJoint *joint, cpBody *a, cpBody *b, cpVect anchorA, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointInit")]
        public static extern IntPtr PivotJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        // CP_EXPORT cpConstraint* cpPivotJointNew(cpBody *a, cpBody *b, cpVect pivot);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointNew")]
        public static extern IntPtr PivotJointNew(IntPtr a, IntPtr b, Vect pivot);

        // CP_EXPORT cpConstraint* cpPivotJointNew2(cpBody *a, cpBody *b, cpVect anchorA, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointNew2")]
        public static extern IntPtr PivotJointNew2(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB);

        // CP_EXPORT void cpPivotJointSetAnchorA(cpConstraint *constraint, cpVect anchorA);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointSetAnchorA")]
        public static extern void PivotJointSetAnchorA(IntPtr constraint, Vect anchorA);

        // CP_EXPORT void cpPivotJointSetAnchorB(cpConstraint *constraint, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPivotJointSetAnchorB")]
        public static extern void PivotJointSetAnchorB(IntPtr constraint, Vect anchorB);

        // CP_EXPORT cpPolylineSet *cpPolylineConvexDecomposition(cpPolyline *line, cpFloat tol);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineConvexDecomposition")]
        public static extern IntPtr PolylineConvexDecomposition(IntPtr line, double tol);

        // CP_EXPORT void cpPolylineFree(cpPolyline *line);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineFree")]
        public static extern void PolylineFree(IntPtr line);

        // CP_EXPORT cpBool cpPolylineIsClosed(cpPolyline *line);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineIsClosed")]
        public static extern bool PolylineIsClosed(IntPtr line);

        // CP_EXPORT cpPolylineSet *cpPolylineSetAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetAlloc")]
        public static extern IntPtr PolylineSetAlloc();

        // CP_EXPORT void cpPolylineSetCollectSegment(cpVect v0, cpVect v1, cpPolylineSet *lines);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetCollectSegment")]
        public static extern void PolylineSetCollectSegment(Vect v0, Vect v1, IntPtr lines);

        // CP_EXPORT void cpPolylineSetDestroy(cpPolylineSet *set, cpBool freePolylines);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetDestroy")]
        public static extern void PolylineSetDestroy(IntPtr set, bool freePolylines);

        // CP_EXPORT void cpPolylineSetFree(cpPolylineSet *set, cpBool freePolylines);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetFree")]
        public static extern void PolylineSetFree(IntPtr set, bool freePolylines);

        // CP_EXPORT cpPolylineSet *cpPolylineSetInit(cpPolylineSet *set);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetInit")]
        public static extern IntPtr PolylineSetInit(IntPtr set);

        // CP_EXPORT cpPolylineSet *cpPolylineSetNew(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSetNew")]
        public static extern IntPtr PolylineSetNew();

        // CP_EXPORT cpPolyline *cpPolylineSimplifyCurves(cpPolyline *line, cpFloat tol);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSimplifyCurves")]
        public static extern IntPtr PolylineSimplifyCurves(IntPtr line, double tol);

        // CP_EXPORT cpPolyline *cpPolylineSimplifyVertexes(cpPolyline *line, cpFloat tol);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineSimplifyVertexes")]
        public static extern IntPtr PolylineSimplifyVertexes(IntPtr line, double tol);

        // CP_EXPORT cpPolyline *cpPolylineToConvexHull(cpPolyline *line, cpFloat tol);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolylineToConvexHull")]
        public static extern IntPtr PolylineToConvexHull(IntPtr line, double tol);

        // CP_EXPORT cpPolyShape* cpPolyShapeAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeAlloc")]
        public static extern IntPtr PolyShapeAlloc();

        // CP_EXPORT int cpPolyShapeGetCount(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeGetCount")]
        public static extern int PolyShapeGetCount(IntPtr shape);

        // CP_EXPORT cpFloat cpPolyShapeGetRadius(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeGetRadius")]
        public static extern double PolyShapeGetRadius(IntPtr shape);

        // CP_EXPORT cpVect cpPolyShapeGetVert(const cpShape *shape, int index);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeGetVert")]
        public static extern Vect PolyShapeGetVert(IntPtr shape, int index);

        // CP_EXPORT cpPolyShape* cpPolyShapeInit(cpPolyShape *poly, cpBody *body, int count, const cpVect *verts, cpTransform transform, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeInit")]
        public static extern IntPtr PolyShapeInit(IntPtr poly, IntPtr body, int count, IntPtr verts, Transform transform, double radius);

        // CP_EXPORT cpPolyShape* cpPolyShapeInitRaw(cpPolyShape *poly, cpBody *body, int count, const cpVect *verts, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeInitRaw")]
        public static extern IntPtr PolyShapeInitRaw(IntPtr poly, IntPtr body, int count, IntPtr verts, double radius);

        // CP_EXPORT cpShape* cpPolyShapeNew(cpBody *body, int count, const cpVect *verts, cpTransform transform, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeNew")]
        public static extern IntPtr PolyShapeNew(IntPtr body, int count, IntPtr verts, Transform transform, double radius);

        // CP_EXPORT cpShape* cpPolyShapeNewRaw(cpBody *body, int count, const cpVect *verts, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeNewRaw")]
        public static extern IntPtr PolyShapeNewRaw(IntPtr body, int count, IntPtr verts, double radius);

        // CP_EXPORT void cpPolyShapeSetRadius(cpShape *shape, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeSetRadius")]
        public static extern void PolyShapeSetRadius(IntPtr shape, double radius);

        // CP_EXPORT void cpPolyShapeSetVerts(cpShape *shape, int count, cpVect *verts, cpTransform transform);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeSetVerts")]
        public static extern void PolyShapeSetVerts(IntPtr shape, int count, IntPtr verts, Transform transform);

        // CP_EXPORT void cpPolyShapeSetVertsRaw(cpShape *shape, int count, cpVect *verts);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpPolyShapeSetVertsRaw")]
        public static extern void PolyShapeSetVertsRaw(IntPtr shape, int count, IntPtr verts);

        // CP_EXPORT cpRatchetJoint* cpRatchetJointAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointAlloc")]
        public static extern IntPtr RatchetJointAlloc();

        // CP_EXPORT cpFloat cpRatchetJointGetAngle(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointGetAngle")]
        public static extern double RatchetJointGetAngle(IntPtr constraint);

        // CP_EXPORT cpFloat cpRatchetJointGetPhase(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointGetPhase")]
        public static extern double RatchetJointGetPhase(IntPtr constraint);

        // CP_EXPORT cpFloat cpRatchetJointGetRatchet(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointGetRatchet")]
        public static extern double RatchetJointGetRatchet(IntPtr constraint);

        // CP_EXPORT cpRatchetJoint* cpRatchetJointInit(cpRatchetJoint *joint, cpBody *a, cpBody *b, cpFloat phase, cpFloat ratchet);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointInit")]
        public static extern IntPtr RatchetJointInit(IntPtr joint, IntPtr a, IntPtr b, double phase, double ratchet);

        // CP_EXPORT cpConstraint* cpRatchetJointNew(cpBody *a, cpBody *b, cpFloat phase, cpFloat ratchet);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointNew")]
        public static extern IntPtr RatchetJointNew(IntPtr a, IntPtr b, double phase, double ratchet);

        // CP_EXPORT void cpRatchetJointSetAngle(cpConstraint *constraint, cpFloat angle);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointSetAngle")]
        public static extern void RatchetJointSetAngle(IntPtr constraint, double angle);

        // CP_EXPORT void cpRatchetJointSetPhase(cpConstraint *constraint, cpFloat phase);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointSetPhase")]
        public static extern void RatchetJointSetPhase(IntPtr constraint, double phase);

        // CP_EXPORT void cpRatchetJointSetRatchet(cpConstraint *constraint, cpFloat ratchet);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRatchetJointSetRatchet")]
        public static extern void RatchetJointSetRatchet(IntPtr constraint, double ratchet);

        // CP_EXPORT cpRotaryLimitJoint* cpRotaryLimitJointAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointAlloc")]
        public static extern IntPtr RotaryLimitJointAlloc();

        // CP_EXPORT cpFloat cpRotaryLimitJointGetMax(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointGetMax")]
        public static extern double RotaryLimitJointGetMax(IntPtr constraint);

        // CP_EXPORT cpFloat cpRotaryLimitJointGetMin(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointGetMin")]
        public static extern double RotaryLimitJointGetMin(IntPtr constraint);

        // CP_EXPORT cpRotaryLimitJoint* cpRotaryLimitJointInit(cpRotaryLimitJoint *joint, cpBody *a, cpBody *b, cpFloat min, cpFloat max);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointInit")]
        public static extern IntPtr RotaryLimitJointInit(IntPtr joint, IntPtr a, IntPtr b, double min, double max);

        // CP_EXPORT cpConstraint* cpRotaryLimitJointNew(cpBody *a, cpBody *b, cpFloat min, cpFloat max);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointNew")]
        public static extern IntPtr RotaryLimitJointNew(IntPtr a, IntPtr b, double min, double max);

        // CP_EXPORT void cpRotaryLimitJointSetMax(cpConstraint *constraint, cpFloat max);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointSetMax")]
        public static extern void RotaryLimitJointSetMax(IntPtr constraint, double max);

        // CP_EXPORT void cpRotaryLimitJointSetMin(cpConstraint *constraint, cpFloat min);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpRotaryLimitJointSetMin")]
        public static extern void RotaryLimitJointSetMin(IntPtr constraint, double min);

        // CP_EXPORT cpSegmentShape* cpSegmentShapeAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeAlloc")]
        public static extern IntPtr SegmentShapeAlloc();

        // CP_EXPORT cpVect cpSegmentShapeGetA(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetA")]
        public static extern Vect SegmentShapeGetA(IntPtr shape);

        // CP_EXPORT cpVect cpSegmentShapeGetB(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetB")]
        public static extern Vect SegmentShapeGetB(IntPtr shape);

        // CP_EXPORT cpVect cpSegmentShapeGetNormal(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetNormal")]
        public static extern Vect SegmentShapeGetNormal(IntPtr shape);

        // CP_EXPORT cpFloat cpSegmentShapeGetRadius(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeGetRadius")]
        public static extern double SegmentShapeGetRadius(IntPtr shape);

        // CP_EXPORT cpSegmentShape* cpSegmentShapeInit(cpSegmentShape *seg, cpBody *body, cpVect a, cpVect b, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeInit")]
        public static extern IntPtr SegmentShapeInit(IntPtr seg, IntPtr body, Vect a, Vect b, double radius);

        // CP_EXPORT cpShape* cpSegmentShapeNew(cpBody *body, cpVect a, cpVect b, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeNew")]
        public static extern IntPtr SegmentShapeNew(IntPtr body, Vect a, Vect b, double radius);

        // CP_EXPORT void cpSegmentShapeSetEndpoints(cpShape *shape, cpVect a, cpVect b);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeSetEndpoints")]
        public static extern void SegmentShapeSetEndpoints(IntPtr shape, Vect a, Vect b);

        // CP_EXPORT void cpSegmentShapeSetNeighbors(cpShape *shape, cpVect prev, cpVect next);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeSetNeighbors")]
        public static extern void SegmentShapeSetNeighbors(IntPtr shape, Vect prev, Vect next);

        // CP_EXPORT void cpSegmentShapeSetRadius(cpShape *shape, cpFloat radius);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSegmentShapeSetRadius")]
        public static extern void SegmentShapeSetRadius(IntPtr shape, double radius);

        // CP_EXPORT cpBB cpShapeCacheBB(cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeCacheBB")]
        public static extern BB ShapeCacheBB(IntPtr shape);

        // CP_EXPORT void cpShapeDestroy(cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeDestroy")]
        public static extern void ShapeDestroy(IntPtr shape);

        // CP_EXPORT void cpShapeFree(cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeFree")]
        public static extern void ShapeFree(IntPtr shape);

        // CP_EXPORT cpFloat cpShapeGetArea(cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetArea")]
        public static extern double ShapeGetArea(IntPtr shape);

        // CP_EXPORT cpBB cpShapeGetBB(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetBB")]
        public static extern BB ShapeGetBB(IntPtr shape);

        // CP_EXPORT cpBody* cpShapeGetBody(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetBody")]
        public static extern IntPtr ShapeGetBody(IntPtr shape);

        // CP_EXPORT cpVect cpShapeGetCenterOfGravity(cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetCenterOfGravity")]
        public static extern Vect ShapeGetCenterOfGravity(IntPtr shape);

        // CP_EXPORT cpCollisionType cpShapeGetCollisionType(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetCollisionType")]
        public static extern uint ShapeGetCollisionType(IntPtr shape);

        // CP_EXPORT cpFloat cpShapeGetDensity(cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetDensity")]
        public static extern double ShapeGetDensity(IntPtr shape);

        // CP_EXPORT cpFloat cpShapeGetElasticity(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetElasticity")]
        public static extern double ShapeGetElasticity(IntPtr shape);

        // CP_EXPORT cpShapeFilter cpShapeGetFilter(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetFilter")]
        public static extern ShapeFilter ShapeGetFilter(IntPtr shape);

        // CP_EXPORT cpFloat cpShapeGetFriction(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetFriction")]
        public static extern double ShapeGetFriction(IntPtr shape);

        // CP_EXPORT cpFloat cpShapeGetMass(cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetMass")]
        public static extern double ShapeGetMass(IntPtr shape);

        // CP_EXPORT cpFloat cpShapeGetMoment(cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetMoment")]
        public static extern double ShapeGetMoment(IntPtr shape);

        // CP_EXPORT cpBool cpShapeGetSensor(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetSensor")]
        public static extern bool ShapeGetSensor(IntPtr shape);

        // CP_EXPORT cpSpace* cpShapeGetSpace(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetSpace")]
        public static extern IntPtr ShapeGetSpace(IntPtr shape);

        // CP_EXPORT cpVect cpShapeGetSurfaceVelocity(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetSurfaceVelocity")]
        public static extern Vect ShapeGetSurfaceVelocity(IntPtr shape);

        // CP_EXPORT cpDataPointer cpShapeGetUserData(const cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeGetUserData")]
        public static extern IntPtr ShapeGetUserData(IntPtr shape);

        // CP_EXPORT cpFloat cpShapePointQuery(const cpShape *shape, cpVect p, cpPointQueryInfo *out);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapePointQuery")]
        public static extern double ShapePointQuery(IntPtr shape, Vect p, IntPtr output);

        // CP_EXPORT cpContactPointSet cpShapesCollide(const cpShape *a, const cpShape *b);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapesCollide")]
        public static extern ContactPointSet ShapesCollide(IntPtr a, IntPtr b);

        // CP_EXPORT cpBool cpShapeSegmentQuery(const cpShape *shape, cpVect a, cpVect b, cpFloat radius, cpSegmentQueryInfo *info);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSegmentQuery")]
        public static extern bool ShapeSegmentQuery(IntPtr shape, Vect a, Vect b, double radius, IntPtr info);

        // CP_EXPORT void cpShapeSetBody(cpShape *shape, cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetBody")]
        public static extern void ShapeSetBody(IntPtr shape, IntPtr body);

        // CP_EXPORT void cpShapeSetCollisionType(cpShape *shape, cpCollisionType collisionType);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetCollisionType")]
        public static extern void ShapeSetCollisionType(IntPtr shape, uint collisionType);

        // CP_EXPORT void cpShapeSetDensity(cpShape *shape, cpFloat density);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetDensity")]
        public static extern void ShapeSetDensity(IntPtr shape, double density);

        // CP_EXPORT void cpShapeSetElasticity(cpShape *shape, cpFloat elasticity);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetElasticity")]
        public static extern void ShapeSetElasticity(IntPtr shape, double elasticity);

        // CP_EXPORT void cpShapeSetFilter(cpShape *shape, cpShapeFilter filter);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetFilter")]
        public static extern void ShapeSetFilter(IntPtr shape, ShapeFilter filter);

        // CP_EXPORT void cpShapeSetFriction(cpShape *shape, cpFloat friction);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetFriction")]
        public static extern void ShapeSetFriction(IntPtr shape, double friction);

        // CP_EXPORT void cpShapeSetMass(cpShape *shape, cpFloat mass);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetMass")]
        public static extern void ShapeSetMass(IntPtr shape, double mass);

        // CP_EXPORT void cpShapeSetSensor(cpShape *shape, cpBool sensor);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetSensor")]
        public static extern void ShapeSetSensor(IntPtr shape, bool sensor);

        // CP_EXPORT void cpShapeSetSurfaceVelocity(cpShape *shape, cpVect surfaceVelocity);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetSurfaceVelocity")]
        public static extern void ShapeSetSurfaceVelocity(IntPtr shape, Vect surfaceVelocity);

        // CP_EXPORT void cpShapeSetUserData(cpShape *shape, cpDataPointer userData);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeSetUserData")]
        public static extern void ShapeSetUserData(IntPtr shape, IntPtr userData);

        // CP_EXPORT cpBB cpShapeUpdate(cpShape *shape, cpTransform transform);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpShapeUpdate")]
        public static extern BB ShapeUpdate(IntPtr shape, Transform transform);

        // CP_EXPORT cpSimpleMotor* cpSimpleMotorAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorAlloc")]
        public static extern IntPtr SimpleMotorAlloc();

        // CP_EXPORT cpFloat cpSimpleMotorGetRate(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorGetRate")]
        public static extern double SimpleMotorGetRate(IntPtr constraint);

        // CP_EXPORT cpSimpleMotor* cpSimpleMotorInit(cpSimpleMotor *joint, cpBody *a, cpBody *b, cpFloat rate);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorInit")]
        public static extern IntPtr SimpleMotorInit(IntPtr joint, IntPtr a, IntPtr b, double rate);

        // CP_EXPORT cpConstraint* cpSimpleMotorNew(cpBody *a, cpBody *b, cpFloat rate);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorNew")]
        public static extern IntPtr SimpleMotorNew(IntPtr a, IntPtr b, double rate);

        // CP_EXPORT void cpSimpleMotorSetRate(cpConstraint *constraint, cpFloat rate);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSimpleMotorSetRate")]
        public static extern void SimpleMotorSetRate(IntPtr constraint, double rate);

        // CP_EXPORT cpSlideJoint* cpSlideJointAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointAlloc")]
        public static extern IntPtr SlideJointAlloc();

        // CP_EXPORT cpVect cpSlideJointGetAnchorA(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetAnchorA")]
        public static extern Vect SlideJointGetAnchorA(IntPtr constraint);

        // CP_EXPORT cpVect cpSlideJointGetAnchorB(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetAnchorB")]
        public static extern Vect SlideJointGetAnchorB(IntPtr constraint);

        // CP_EXPORT cpFloat cpSlideJointGetMax(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetMax")]
        public static extern double SlideJointGetMax(IntPtr constraint);

        // CP_EXPORT cpFloat cpSlideJointGetMin(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointGetMin")]
        public static extern double SlideJointGetMin(IntPtr constraint);

        // CP_EXPORT cpSlideJoint* cpSlideJointInit(cpSlideJoint *joint, cpBody *a, cpBody *b, cpVect anchorA, cpVect anchorB, cpFloat min, cpFloat max);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointInit")]
        public static extern IntPtr SlideJointInit(IntPtr joint, IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double min, double max);

        // CP_EXPORT cpConstraint* cpSlideJointNew(cpBody *a, cpBody *b, cpVect anchorA, cpVect anchorB, cpFloat min, cpFloat max);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointNew")]
        public static extern IntPtr SlideJointNew(IntPtr a, IntPtr b, Vect anchorA, Vect anchorB, double min, double max);

        // CP_EXPORT void cpSlideJointSetAnchorA(cpConstraint *constraint, cpVect anchorA);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetAnchorA")]
        public static extern void SlideJointSetAnchorA(IntPtr constraint, Vect anchorA);

        // CP_EXPORT void cpSlideJointSetAnchorB(cpConstraint *constraint, cpVect anchorB);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetAnchorB")]
        public static extern void SlideJointSetAnchorB(IntPtr constraint, Vect anchorB);

        // CP_EXPORT void cpSlideJointSetMax(cpConstraint *constraint, cpFloat max);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetMax")]
        public static extern void SlideJointSetMax(IntPtr constraint, double max);

        // CP_EXPORT void cpSlideJointSetMin(cpConstraint *constraint, cpFloat min);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSlideJointSetMin")]
        public static extern void SlideJointSetMin(IntPtr constraint, double min);

        // CP_EXPORT cpBody* cpSpaceAddBody(cpSpace *space, cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddBody")]
        public static extern IntPtr SpaceAddBody(IntPtr space, IntPtr body);

        // CP_EXPORT cpCollisionHandler *cpSpaceAddCollisionHandler(cpSpace *space, cpCollisionType a, cpCollisionType b);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddCollisionHandler")]
        public static extern IntPtr SpaceAddCollisionHandler(IntPtr space, uint a, uint b);

        // CP_EXPORT cpConstraint* cpSpaceAddConstraint(cpSpace *space, cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddConstraint")]
        public static extern IntPtr SpaceAddConstraint(IntPtr space, IntPtr constraint);

        // CP_EXPORT cpCollisionHandler *cpSpaceAddDefaultCollisionHandler(cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddDefaultCollisionHandler")]
        public static extern IntPtr SpaceAddDefaultCollisionHandler(IntPtr space);

        // CP_EXPORT cpBool cpSpaceAddPostStepCallback(cpSpace *space, cpPostStepFunc func, void *key, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddPostStepCallback")]
        public static extern bool SpaceAddPostStepCallback(IntPtr space, IntPtr func, IntPtr key, IntPtr data);

        // CP_EXPORT cpShape* cpSpaceAddShape(cpSpace *space, cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddShape")]
        public static extern IntPtr SpaceAddShape(IntPtr space, IntPtr shape);

        // CP_EXPORT cpCollisionHandler *cpSpaceAddWildcardHandler(cpSpace *space, cpCollisionType type);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAddWildcardHandler")]
        public static extern IntPtr SpaceAddWildcardHandler(IntPtr space, uint type);

        // CP_EXPORT cpSpace* cpSpaceAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceAlloc")]
        public static extern IntPtr SpaceAlloc();

        // CP_EXPORT void cpSpaceBBQuery(cpSpace *space, cpBB bb, cpShapeFilter filter, cpSpaceBBQueryFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceBBQuery")]
        public static extern void SpaceBBQuery(IntPtr space, BB bb, ShapeFilter filter, IntPtr func, IntPtr data);

        // CP_EXPORT cpBool cpSpaceContainsBody(cpSpace *space, cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceContainsBody")]
        public static extern bool SpaceContainsBody(IntPtr space, IntPtr body);

        // CP_EXPORT cpBool cpSpaceContainsConstraint(cpSpace *space, cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceContainsConstraint")]
        public static extern bool SpaceContainsConstraint(IntPtr space, IntPtr constraint);

        // CP_EXPORT cpBool cpSpaceContainsShape(cpSpace *space, cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceContainsShape")]
        public static extern bool SpaceContainsShape(IntPtr space, IntPtr shape);

        // CP_EXPORT void cpSpaceDebugDraw(cpSpace *space, cpSpaceDebugDrawOptions *options);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceDebugDraw")]
        public static extern void SpaceDebugDraw(IntPtr space, IntPtr options);

        // CP_EXPORT void cpSpaceDestroy(cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceDestroy")]
        public static extern void SpaceDestroy(IntPtr space);

        // CP_EXPORT void cpSpaceEachBody(cpSpace *space, cpSpaceBodyIteratorFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceEachBody")]
        public static extern void SpaceEachBody(IntPtr space, IntPtr func, IntPtr data);

        // CP_EXPORT void cpSpaceEachConstraint(cpSpace *space, cpSpaceConstraintIteratorFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceEachConstraint")]
        public static extern void SpaceEachConstraint(IntPtr space, IntPtr func, IntPtr data);

        // CP_EXPORT void cpSpaceEachShape(cpSpace *space, cpSpaceShapeIteratorFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceEachShape")]
        public static extern void SpaceEachShape(IntPtr space, IntPtr func, IntPtr data);

        // CP_EXPORT void cpSpaceFree(cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceFree")]
        public static extern void SpaceFree(IntPtr space);

        // CP_EXPORT cpFloat cpSpaceGetCollisionBias(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetCollisionBias")]
        public static extern double SpaceGetCollisionBias(IntPtr space);

        // CP_EXPORT cpTimestamp cpSpaceGetCollisionPersistence(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetCollisionPersistence")]
        public static extern uint SpaceGetCollisionPersistence(IntPtr space);

        // CP_EXPORT cpFloat cpSpaceGetCollisionSlop(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetCollisionSlop")]
        public static extern double SpaceGetCollisionSlop(IntPtr space);

        // CP_EXPORT cpFloat cpSpaceGetCurrentTimeStep(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetCurrentTimeStep")]
        public static extern double SpaceGetCurrentTimeStep(IntPtr space);

        // CP_EXPORT cpFloat cpSpaceGetDamping(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetDamping")]
        public static extern double SpaceGetDamping(IntPtr space);

        // CP_EXPORT cpVect cpSpaceGetGravity(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetGravity")]
        public static extern Vect SpaceGetGravity(IntPtr space);

        // CP_EXPORT cpFloat cpSpaceGetIdleSpeedThreshold(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetIdleSpeedThreshold")]
        public static extern double SpaceGetIdleSpeedThreshold(IntPtr space);

        // CP_EXPORT int cpSpaceGetIterations(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetIterations")]
        public static extern int SpaceGetIterations(IntPtr space);

        // CP_EXPORT cpFloat cpSpaceGetSleepTimeThreshold(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetSleepTimeThreshold")]
        public static extern double SpaceGetSleepTimeThreshold(IntPtr space);

        // CP_EXPORT cpBody* cpSpaceGetStaticBody(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetStaticBody")]
        public static extern IntPtr SpaceGetStaticBody(IntPtr space);

        // CP_EXPORT cpDataPointer cpSpaceGetUserData(const cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceGetUserData")]
        public static extern IntPtr SpaceGetUserData(IntPtr space);

        // CP_EXPORT cpSpaceHash* cpSpaceHashAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceHashAlloc")]
        public static extern IntPtr SpaceHashAlloc();

        // CP_EXPORT cpSpatialIndex* cpSpaceHashInit(cpSpaceHash *hash, cpFloat celldim, int numcells, cpSpatialIndexBBFunc bbfunc, cpSpatialIndex *staticIndex);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceHashInit")]
        public static extern IntPtr SpaceHashInit(IntPtr hash, double celldim, int numcells, IntPtr bbfunc, IntPtr staticIndex);

        // CP_EXPORT cpSpatialIndex* cpSpaceHashNew(cpFloat celldim, int cells, cpSpatialIndexBBFunc bbfunc, cpSpatialIndex *staticIndex);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceHashNew")]
        public static extern IntPtr SpaceHashNew(double celldim, int cells, IntPtr bbfunc, IntPtr staticIndex);

        // CP_EXPORT void cpSpaceHashResize(cpSpaceHash *hash, cpFloat celldim, int numcells);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceHashResize")]
        public static extern void SpaceHashResize(IntPtr hash, double celldim, int numcells);

        // CP_EXPORT cpSpace* cpSpaceInit(cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceInit")]
        public static extern IntPtr SpaceInit(IntPtr space);

        // CP_EXPORT cpBool cpSpaceIsLocked(cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceIsLocked")]
        public static extern bool SpaceIsLocked(IntPtr space);

        // CP_EXPORT cpSpace* cpSpaceNew(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceNew")]
        public static extern IntPtr SpaceNew();

        // CP_EXPORT void cpSpacePointQuery(cpSpace *space, cpVect point, cpFloat maxDistance, cpShapeFilter filter, cpSpacePointQueryFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpacePointQuery")]
        public static extern void SpacePointQuery(IntPtr space, Vect point, double maxDistance, ShapeFilter filter, IntPtr func, IntPtr data);

        // CP_EXPORT cpShape *cpSpacePointQueryNearest(cpSpace *space, cpVect point, cpFloat maxDistance, cpShapeFilter filter, cpPointQueryInfo *out);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpacePointQueryNearest")]
        public static extern IntPtr SpacePointQueryNearest(IntPtr space, Vect point, double maxDistance, ShapeFilter filter, IntPtr output);

        // CP_EXPORT void cpSpaceReindexShape(cpSpace *space, cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceReindexShape")]
        public static extern void SpaceReindexShape(IntPtr space, IntPtr shape);

        // CP_EXPORT void cpSpaceReindexShapesForBody(cpSpace *space, cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceReindexShapesForBody")]
        public static extern void SpaceReindexShapesForBody(IntPtr space, IntPtr body);

        // CP_EXPORT void cpSpaceReindexStatic(cpSpace *space);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceReindexStatic")]
        public static extern void SpaceReindexStatic(IntPtr space);

        // CP_EXPORT void cpSpaceRemoveBody(cpSpace *space, cpBody *body);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceRemoveBody")]
        public static extern void SpaceRemoveBody(IntPtr space, IntPtr body);

        // CP_EXPORT void cpSpaceRemoveConstraint(cpSpace *space, cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceRemoveConstraint")]
        public static extern void SpaceRemoveConstraint(IntPtr space, IntPtr constraint);

        // CP_EXPORT void cpSpaceRemoveShape(cpSpace *space, cpShape *shape);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceRemoveShape")]
        public static extern void SpaceRemoveShape(IntPtr space, IntPtr shape);

        // CP_EXPORT void cpSpaceSegmentQuery(cpSpace *space, cpVect start, cpVect end, cpFloat radius, cpShapeFilter filter, cpSpaceSegmentQueryFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSegmentQuery")]
        public static extern void SpaceSegmentQuery(IntPtr space, Vect start, Vect end, double radius, ShapeFilter filter, IntPtr func, IntPtr data);

        // CP_EXPORT cpShape *cpSpaceSegmentQueryFirst(cpSpace *space, cpVect start, cpVect end, cpFloat radius, cpShapeFilter filter, cpSegmentQueryInfo *out);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSegmentQueryFirst")]
        public static extern IntPtr SpaceSegmentQueryFirst(IntPtr space, Vect start, Vect end, double radius, ShapeFilter filter, IntPtr output);

        // CP_EXPORT void cpSpaceSetCollisionBias(cpSpace *space, cpFloat collisionBias);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetCollisionBias")]
        public static extern void SpaceSetCollisionBias(IntPtr space, double collisionBias);

        // CP_EXPORT void cpSpaceSetCollisionPersistence(cpSpace *space, cpTimestamp collisionPersistence);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetCollisionPersistence")]
        public static extern void SpaceSetCollisionPersistence(IntPtr space, uint collisionPersistence);

        // CP_EXPORT void cpSpaceSetCollisionSlop(cpSpace *space, cpFloat collisionSlop);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetCollisionSlop")]
        public static extern void SpaceSetCollisionSlop(IntPtr space, double collisionSlop);

        // CP_EXPORT void cpSpaceSetDamping(cpSpace *space, cpFloat damping);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetDamping")]
        public static extern void SpaceSetDamping(IntPtr space, double damping);

        // CP_EXPORT void cpSpaceSetGravity(cpSpace *space, cpVect gravity);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetGravity")]
        public static extern void SpaceSetGravity(IntPtr space, Vect gravity);

        // CP_EXPORT void cpSpaceSetIdleSpeedThreshold(cpSpace *space, cpFloat idleSpeedThreshold);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetIdleSpeedThreshold")]
        public static extern void SpaceSetIdleSpeedThreshold(IntPtr space, double idleSpeedThreshold);

        // CP_EXPORT void cpSpaceSetIterations(cpSpace *space, int iterations);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetIterations")]
        public static extern void SpaceSetIterations(IntPtr space, int iterations);

        // CP_EXPORT void cpSpaceSetSleepTimeThreshold(cpSpace *space, cpFloat sleepTimeThreshold);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetSleepTimeThreshold")]
        public static extern void SpaceSetSleepTimeThreshold(IntPtr space, double sleepTimeThreshold);

        // CP_EXPORT void cpSpaceSetUserData(cpSpace *space, cpDataPointer userData);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceSetUserData")]
        public static extern void SpaceSetUserData(IntPtr space, IntPtr userData);

        // CP_EXPORT cpBool cpSpaceShapeQuery(cpSpace *space, cpShape *shape, cpSpaceShapeQueryFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceShapeQuery")]
        public static extern bool SpaceShapeQuery(IntPtr space, IntPtr shape, IntPtr func, IntPtr data);

        // CP_EXPORT void cpSpaceStep(cpSpace *space, cpFloat dt);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceStep")]
        public static extern void SpaceStep(IntPtr space, double dt);

        // CP_EXPORT void cpSpaceUseSpatialHash(cpSpace *space, cpFloat dim, int count);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpaceUseSpatialHash")]
        public static extern void SpaceUseSpatialHash(IntPtr space, double dim, int count);

        // CP_EXPORT void cpSpatialIndexCollideStatic(cpSpatialIndex *dynamicIndex, cpSpatialIndex *staticIndex, cpSpatialIndexQueryFunc func, void *data);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpatialIndexCollideStatic")]
        public static extern void SpatialIndexCollideStatic(IntPtr dynamicIndex, IntPtr staticIndex, IntPtr func, IntPtr data);

        // CP_EXPORT void cpSpatialIndexFree(cpSpatialIndex *index);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSpatialIndexFree")]
        public static extern void SpatialIndexFree(IntPtr index);

        // CP_EXPORT cpSweep1D* cpSweep1DAlloc(void);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSweep1DAlloc")]
        public static extern IntPtr Sweep1DAlloc();

        // CP_EXPORT cpSpatialIndex* cpSweep1DInit(cpSweep1D *sweep, cpSpatialIndexBBFunc bbfunc, cpSpatialIndex *staticIndex);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSweep1DInit")]
        public static extern IntPtr Sweep1DInit(IntPtr sweep, IntPtr bbfunc, IntPtr staticIndex);

        // CP_EXPORT cpSpatialIndex* cpSweep1DNew(cpSpatialIndexBBFunc bbfunc, cpSpatialIndex *staticIndex);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSweep1DNew")]
        public static extern IntPtr Sweep1DNew(IntPtr bbfunc, IntPtr staticIndex);

    }
}

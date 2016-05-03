using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Arbiter {
        public IntPtr arb { get; private set; }

        // CP_EXPORT cpBool cpArbiterCallWildcardBeginA(cpArbiter *arb, cpSpace *space);
        public bool CallWildcardBeginA(IntPtr space) {
            return CP.ArbiterCallWildcardBeginA(arb, space);
        }

        // CP_EXPORT cpBool cpArbiterCallWildcardBeginB(cpArbiter *arb, cpSpace *space);
        public bool CallWildcardBeginB(IntPtr space) {
            return CP.ArbiterCallWildcardBeginB(arb, space);
        }

        // CP_EXPORT void cpArbiterCallWildcardPostSolveA(cpArbiter *arb, cpSpace *space);
        public void CallWildcardPostSolveA(IntPtr space) {
            CP.ArbiterCallWildcardPostSolveA(arb, space);
        }

        // CP_EXPORT void cpArbiterCallWildcardPostSolveB(cpArbiter *arb, cpSpace *space);
        public void CallWildcardPostSolveB(IntPtr space) {
            CP.ArbiterCallWildcardPostSolveB(arb, space);
        }

        // CP_EXPORT cpBool cpArbiterCallWildcardPreSolveA(cpArbiter *arb, cpSpace *space);
        public bool CallWildcardPreSolveA(IntPtr space) {
            return CP.ArbiterCallWildcardPreSolveA(arb, space);
        }

        // CP_EXPORT cpBool cpArbiterCallWildcardPreSolveB(cpArbiter *arb, cpSpace *space);
        public bool CallWildcardPreSolveB(IntPtr space) {
            return CP.ArbiterCallWildcardPreSolveB(arb, space);
        }

        // CP_EXPORT void cpArbiterCallWildcardSeparateA(cpArbiter *arb, cpSpace *space);
        public void CallWildcardSeparateA(IntPtr space) {
            CP.ArbiterCallWildcardSeparateA(arb, space);
        }

        // CP_EXPORT void cpArbiterCallWildcardSeparateB(cpArbiter *arb, cpSpace *space);
        public void CallWildcardSeparateB(IntPtr space) {
            CP.ArbiterCallWildcardSeparateB(arb, space);
        }

        // CP_EXPORT void cpArbiterGetBodies(const cpArbiter *arb, cpBody **a, cpBody **b);
        public void GetBodies(IntPtr a, IntPtr b) {
            CP.ArbiterGetBodies(arb, a, b);
        }

        // CP_EXPORT int cpArbiterGetCount(const cpArbiter *arb);
        public int GetCount() {
            return CP.ArbiterGetCount(arb);
        }

        // CP_EXPORT cpFloat cpArbiterGetDepth(const cpArbiter *arb, int i);
        public double GetDepth(int i) {
            return CP.ArbiterGetDepth(arb, i);
        }

        // CP_EXPORT cpFloat cpArbiterGetFriction(const cpArbiter *arb);
        public double GetFriction() {
            return CP.ArbiterGetFriction(arb);
        }

        // CP_EXPORT cpVect cpArbiterGetNormal(const cpArbiter *arb);
        public Vect GetNormal() {
            return CP.ArbiterGetNormal(arb);
        }

        // CP_EXPORT cpVect cpArbiterGetPointA(const cpArbiter *arb, int i);
        public Vect GetPointA(int i) {
            return CP.ArbiterGetPointA(arb, i);
        }

        // CP_EXPORT cpVect cpArbiterGetPointB(const cpArbiter *arb, int i);
        public Vect GetPointB(int i) {
            return CP.ArbiterGetPointB(arb, i);
        }

        // CP_EXPORT cpFloat cpArbiterGetRestitution(const cpArbiter *arb);
        public double GetRestitution() {
            return CP.ArbiterGetRestitution(arb);
        }

        // CP_EXPORT void cpArbiterGetShapes(const cpArbiter *arb, cpShape **a, cpShape **b);
        public void GetShapes(IntPtr a, IntPtr b) {
            CP.ArbiterGetShapes(arb, a, b);
        }

        // CP_EXPORT cpVect cpArbiterGetSurfaceVelocity(cpArbiter *arb);
        public Vect GetSurfaceVelocity() {
            return CP.ArbiterGetSurfaceVelocity(arb);
        }

        // CP_EXPORT cpDataPointer cpArbiterGetUserData(const cpArbiter *arb);
        public IntPtr GetUserData() {
            return CP.ArbiterGetUserData(arb);
        }

        // CP_EXPORT cpBool cpArbiterIgnore(cpArbiter *arb);
        public bool Ignore() {
            return CP.ArbiterIgnore(arb);
        }

        // CP_EXPORT cpBool cpArbiterIsFirstContact(const cpArbiter *arb);
        public bool IsFirstContact() {
            return CP.ArbiterIsFirstContact(arb);
        }

        // CP_EXPORT cpBool cpArbiterIsRemoval(const cpArbiter *arb);
        public bool IsRemoval() {
            return CP.ArbiterIsRemoval(arb);
        }

        // CP_EXPORT void cpArbiterSetContactPointSet(cpArbiter *arb, cpContactPointSet *set);
        public void SetContactPointSet(IntPtr set) {
            CP.ArbiterSetContactPointSet(arb, set);
        }

        // CP_EXPORT void cpArbiterSetFriction(cpArbiter *arb, cpFloat friction);
        public void SetFriction(double friction) {
            CP.ArbiterSetFriction(arb, friction);
        }

        // CP_EXPORT void cpArbiterSetRestitution(cpArbiter *arb, cpFloat restitution);
        public void SetRestitution(double restitution) {
            CP.ArbiterSetRestitution(arb, restitution);
        }

        // CP_EXPORT void cpArbiterSetSurfaceVelocity(cpArbiter *arb, cpVect vr);
        public void SetSurfaceVelocity(Vect vr) {
            CP.ArbiterSetSurfaceVelocity(arb, vr);
        }

        // CP_EXPORT void cpArbiterSetUserData(cpArbiter *arb, cpDataPointer userData);
        public void SetUserData(IntPtr userData) {
            CP.ArbiterSetUserData(arb, userData);
        }

        // CP_EXPORT cpVect cpArbiterTotalImpulse(const cpArbiter *arb);
        public Vect TotalImpulse() {
            return CP.ArbiterTotalImpulse(arb);
        }

        // CP_EXPORT cpFloat cpArbiterTotalKE(const cpArbiter *arb);
        public double TotalKE() {
            return CP.ArbiterTotalKE(arb);
        }

    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Arbiter {
        public IntPtr Handle { get; set; }

        public Arbiter(IntPtr handle) {
            Handle = handle;
        }

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

        public void GetBodies(IntPtr a, IntPtr b) {
            CP.ArbiterGetBodies(Handle, a, b);
        }

        public int GetCount() {
            return CP.ArbiterGetCount(Handle);
        }

        public double GetDepth(int i) {
            return CP.ArbiterGetDepth(Handle, i);
        }

        public double GetFriction() {
            return CP.ArbiterGetFriction(Handle);
        }

        public Vect GetNormal() {
            return CP.ArbiterGetNormal(Handle);
        }

        public Vect GetPointA(int i) {
            return CP.ArbiterGetPointA(Handle, i);
        }

        public Vect GetPointB(int i) {
            return CP.ArbiterGetPointB(Handle, i);
        }

        public double GetRestitution() {
            return CP.ArbiterGetRestitution(Handle);
        }

        public void GetShapes(IntPtr a, IntPtr b) {
            CP.ArbiterGetShapes(Handle, a, b);
        }

        public Vect GetSurfaceVelocity() {
            return CP.ArbiterGetSurfaceVelocity(Handle);
        }

        public IntPtr GetUserData() {
            return CP.ArbiterGetUserData(Handle);
        }

        public bool Ignore() {
            return CP.ArbiterIgnore(Handle);
        }

        public bool IsFirstContact() {
            return CP.ArbiterIsFirstContact(Handle);
        }

        public bool IsRemoval() {
            return CP.ArbiterIsRemoval(Handle);
        }

        public void SetContactPointSet(IntPtr set) {
            CP.ArbiterSetContactPointSet(Handle, set);
        }

        public void SetFriction(double friction) {
            CP.ArbiterSetFriction(Handle, friction);
        }

        public void SetRestitution(double restitution) {
            CP.ArbiterSetRestitution(Handle, restitution);
        }

        public void SetSurfaceVelocity(Vect vr) {
            CP.ArbiterSetSurfaceVelocity(Handle, vr);
        }

        public void SetUserData(IntPtr userData) {
            CP.ArbiterSetUserData(Handle, userData);
        }

        public Vect TotalImpulse() {
            return CP.ArbiterTotalImpulse(Handle);
        }

        public double TotalKE() {
            return CP.ArbiterTotalKE(Handle);
        }

    }
}

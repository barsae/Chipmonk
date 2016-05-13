using System;

namespace Chipmonk.CApi {
    public class RawDelegates {
        public delegate void RawBodyVelocityFunc(IntPtr body, Vect gravity, double damping, double dt);
        public delegate void RawBodyPositionFunc(IntPtr body, double dt);

        public delegate bool RawCollisionBeginFunc(IntPtr arb, IntPtr space, IntPtr userData);
        public delegate bool RawCollisionPreSolveFunc(IntPtr arb, IntPtr space, IntPtr userData);
        public delegate void RawCollisionPostSolveFunc(IntPtr arb, IntPtr space, IntPtr userData);
        public delegate void RawCollisionSeparateFunc(IntPtr arb, IntPtr space, IntPtr userData);

        public delegate BB SpatialIndexBBFunc(IntPtr obj);
        public delegate void SpatialIndexIteratorFunc(IntPtr obj, IntPtr data);
        public delegate uint SpatialIndexQueryFunc(IntPtr obj1, IntPtr obj2, uint id, IntPtr data);
        public delegate double SpatialIndexSegmentQueryFunc(IntPtr obj1, IntPtr obj2, IntPtr data);
    }
}

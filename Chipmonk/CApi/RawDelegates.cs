using System;
using System.Runtime.InteropServices;

namespace Chipmonk.CApi {
    public class RawDelegates {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RawBodyVelocityFunc(IntPtr body, Vect gravity, double damping, double dt);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RawBodyPositionFunc(IntPtr body, double dt);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate byte RawCollisionBeginFunc(IntPtr arb, IntPtr space, IntPtr userData);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate byte RawCollisionPreSolveFunc(IntPtr arb, IntPtr space, IntPtr userData);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RawCollisionPostSolveFunc(IntPtr arb, IntPtr space, IntPtr userData);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RawCollisionSeparateFunc(IntPtr arb, IntPtr space, IntPtr userData);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate BB SpatialIndexBBFunc(IntPtr obj);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void SpatialIndexIteratorFunc(IntPtr obj, IntPtr data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint SpatialIndexQueryFunc(IntPtr obj1, IntPtr obj2, uint id, IntPtr data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double SpatialIndexSegmentQueryFunc(IntPtr obj1, IntPtr obj2, IntPtr data);
    }
}

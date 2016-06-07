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
        public delegate BB RawSpatialIndexBBFunc(IntPtr obj);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RawSpatialIndexIteratorFunc(IntPtr obj, IntPtr data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint RawSpatialIndexQueryFunc(IntPtr obj1, IntPtr obj2, uint id, IntPtr data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double RawSpatialIndexSegmentQueryFunc(IntPtr obj1, IntPtr obj2, IntPtr data);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RawSpacePointQueryFunc(IntPtr shape, Vect point, double distance, Vect gradient, IntPtr data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RawSpaceSegmentQueryFunc(IntPtr shape, Vect point, Vect normal, double alpha, IntPtr data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RawSpaceBBQueryFunc(IntPtr shape, IntPtr data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RawSpaceShapeQueryFunc(IntPtr shape, IntPtr points, IntPtr data);
    }
}

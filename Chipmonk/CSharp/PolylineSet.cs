using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PolylineSet {
        public IntPtr set { get; set; }

        public PolylineSet() {
            set = CP.PolylineSetNew();
        }

        // CP_EXPORT void cpPolylineSetCollectSegment(cpVect v0, cpVect v1, cpPolylineSet *lines);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpCollectSegment")]
        public static extern void CollectSegment(Vect v0, Vect v1, IntPtr lines);

    }
}

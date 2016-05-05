using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PolylineSet : Shape {
        public PolylineSet() : base(CP.PolylineSetNew()) {
        }

        public PolylineSet(IntPtr handle) : base(handle) {
        }

        public static PolylineSet Alloc() {
            return new PolylineSet(CP.PolylineSetAlloc());
        }

        public static void CollectSegment(Vect v0, Vect v1, PolylineSet lines) {
            CP.PolylineSetCollectSegment(v0, v1, lines.Handle);
        }

        public void Destroy(bool freePolylines) {
            CP.PolylineSetDestroy(Handle, freePolylines);
        }

        public void Free(bool freePolylines) {
            CP.PolylineSetFree(Handle, freePolylines);
        }

        public PolylineSet Init() {
            return new PolylineSet(CP.PolylineSetInit(Handle));
        }

        public static PolylineSet New() {
            return new PolylineSet(CP.PolylineSetNew());
        }

    }
}

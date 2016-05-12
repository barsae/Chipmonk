using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PolylineSet : Shape {
        public PolylineSet() {
            Handle = CP.PolylineSetNew();
        }

        internal PolylineSet(IntPtr handle) {
            Handle = handle;
        }

        public static void CollectSegment(Vect v0, Vect v1, PolylineSet lines) {
            CP.PolylineSetCollectSegment(v0, v1, lines.Handle);
        }

        public override void Dispose() {
            // TODO: Understand the second parameter here
            throw new NotImplementedException();
            CP.PolylineSetFree(Handle, true);
        }
    }
}

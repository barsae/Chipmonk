using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Polyline : Shape {
        public Polyline(IntPtr handle) : base(handle) {
        }

        public PolylineSet ConvexDecomposition(double tol) {
            return new PolylineSet(CP.PolylineConvexDecomposition(Handle, tol));
        }

        public override void Free() {
            CP.PolylineFree(Handle);
        }

        public bool IsClosed() {
            return CP.PolylineIsClosed(Handle);
        }

        public Polyline SimplifyCurves(double tol) {
            return new Polyline(CP.PolylineSimplifyCurves(Handle, tol));
        }

        public Polyline SimplifyVertexes(double tol) {
            return new Polyline(CP.PolylineSimplifyVertexes(Handle, tol));
        }

        public Polyline ToConvexHull(double tol) {
            return new Polyline(CP.PolylineToConvexHull(Handle, tol));
        }

    }
}

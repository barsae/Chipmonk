using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Polyline {
        public IntPtr line { get; private set; }

        // CP_EXPORT cpPolylineSet *cpPolylineConvexDecomposition(cpPolyline *line, cpFloat tol);
        public IntPtr ConvexDecomposition(double tol) {
            return CP.PolylineConvexDecomposition(line, tol);
        }

        // CP_EXPORT cpBool cpPolylineIsClosed(cpPolyline *line);
        public bool IsClosed() {
            return CP.PolylineIsClosed(line);
        }

        // CP_EXPORT cpPolyline *cpPolylineSimplifyCurves(cpPolyline *line, cpFloat tol);
        public IntPtr SimplifyCurves(double tol) {
            return CP.PolylineSimplifyCurves(line, tol);
        }

        // CP_EXPORT cpPolyline *cpPolylineSimplifyVertexes(cpPolyline *line, cpFloat tol);
        public IntPtr SimplifyVertexes(double tol) {
            return CP.PolylineSimplifyVertexes(line, tol);
        }

        // CP_EXPORT cpPolyline *cpPolylineToConvexHull(cpPolyline *line, cpFloat tol);
        public IntPtr ToConvexHull(double tol) {
            return CP.PolylineToConvexHull(line, tol);
        }

    }
}

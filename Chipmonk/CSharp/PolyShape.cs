using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class PolyShape : Shape {
        #region Properties
        public Vect[] Verts {
            get {
                return _verts;
            }
            set {
                var vertsHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
                CP.PolyShapeSetVertsRaw(Handle, value.Length, vertsHandle.AddrOfPinnedObject());
                vertsHandle.Free();
            }
        }
        private Vect[] _verts;

        public double Radius {
            get {
                return CP.PolyShapeGetRadius(Handle);
            }
            set {
                CP.PolyShapeSetRadius(Handle, value);
            }
        }
        #endregion Properties

        public PolyShape(Body body, Vect[] verts, double radius) {
            var vertsHandle = GCHandle.Alloc(verts, GCHandleType.Pinned);
            Handle = CP.PolyShapeNewRaw(body.Handle, verts.Length, vertsHandle.AddrOfPinnedObject(), radius);
            vertsHandle.Free();
            _verts = verts;
        }
    }
}

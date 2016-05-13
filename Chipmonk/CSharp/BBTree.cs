using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class BBTree {
        internal IntPtr Handle { get; private set; }

        public BBTree(Delegates.SpatialIndexBBFunc bbfunc, SpatialIndex index) {
            var marshaledBBFunc = Marshal.GetFunctionPointerForDelegate(
                    new RawDelegates.SpatialIndexBBFunc((obj) => {
                    return bbfunc(obj);
                }));
            Handle = CP.BBTreeNew(marshaledBBFunc, index.Handle);
        }

        internal BBTree(IntPtr handle) {
            Handle = handle;
        }
    }
}

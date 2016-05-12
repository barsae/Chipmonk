using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class BBTree {
        internal IntPtr Handle { get; set; }

        public BBTree() {
            throw new NotImplementedException();
            //Handle = CP.BBTreeNew(null, null);
        }

        internal BBTree(IntPtr handle) {
            Handle = handle;
        }

        public static void Optimize(IntPtr index) {
            CP.BBTreeOptimize(index);
        }
    }
}

using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class BBTree {
        public IntPtr Handle { get; set; }

        public BBTree(IntPtr handle) {
            Handle = handle;
        }

        public static BBTree Alloc() {
            return new BBTree(CP.BBTreeAlloc());
        }

        public static void Optimize(IntPtr index) {
            CP.BBTreeOptimize(index);
        }

    }
}

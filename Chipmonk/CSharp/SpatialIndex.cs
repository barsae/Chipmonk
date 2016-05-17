using Chipmonk.CApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.CSharp {
    public class SpatialIndex : ForeignReference {
        internal SpatialIndex(IntPtr handle) {
            Handle = handle;
        }

        public void Optimize() {
            CP.BBTreeOptimize(Handle);
        }

        public void SetVelocityFunc(IntPtr func) {
            CP.BBTreeSetVelocityFunc(Handle, func);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.CSharp {
    public class ForeignReference {
        internal IntPtr Handle { get; set; }

        public override bool Equals(object obj) {
            var reference = obj as ForeignReference;
            return reference != null && reference.Handle == Handle;
        }

        public override int GetHashCode() {
            return Handle.GetHashCode();
        }
    }
}

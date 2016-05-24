using System;
using System.Collections.Generic;

namespace Chipmonk.CSharp {
    public static class ReferenceManager {
        private static int next = 1;
        private static Dictionary<IntPtr, object> references = new Dictionary<IntPtr, object>();

        public static IntPtr AllocateReference(object obj) {
            var id = (IntPtr)next;
            next++;

            references[id] = obj;
            return id;
        }

        public static void DeallocateReference(IntPtr id) {
            references.Remove(id);
        }

        public static object Dereference(IntPtr id) {
            return references[id];
        }
    }
}

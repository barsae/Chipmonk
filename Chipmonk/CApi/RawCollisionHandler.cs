using System;

namespace Chipmonk.CApi {
    public struct RawCollisionHandler {
        public uint typeA;
        public uint typeB;
        public IntPtr beginFunc;
        public IntPtr preSolveFunc;
        public IntPtr postSolveFunc;
        public IntPtr separateFunc;
        public IntPtr userData;
    }
}

using Chipmonk.CApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.CSharp {
    public class CollisionHandler {
        internal IntPtr Handle { get; private set; }
        private RawCollisionHandler rawHandler;
        private IntPtr _defaultBeginFunc;
        private IntPtr _defaultPreSolveFunc;
        private IntPtr _defaultPostSolveFunc;
        private IntPtr _defaultSeperateFunc;

        #region Properties
        public uint TypeA { get; private set; }
        public uint TypeB { get; private set; }

        public Delegates.CollisionBeginFunc BeginFunc {
            get {
                return _beginFunc;
            }
            set {
                _beginFunc = value;
                Write();
            }
        }
        private Delegates.CollisionBeginFunc _beginFunc;

        public Delegates.CollisionPreSolveFunc PreSolveFunc {
            get {
                return _preSolveFunc;
            }
            set {
                _preSolveFunc = value;
                Write();
            }
        }
        private Delegates.CollisionPreSolveFunc _preSolveFunc;

        public Delegates.CollisionPostSolveFunc PostSolveFunc {
            get {
                return _postSolveFunc;
            }
            set {
                _postSolveFunc = value;
                Write();
            }
        }
        private Delegates.CollisionPostSolveFunc _postSolveFunc;

        public Delegates.CollisionSeparateFunc SeparateFunc {
            get {
                return _seperateFunc;
            }
            set {
                _seperateFunc = value;
                Write();
            }
        }
        private Delegates.CollisionSeparateFunc _seperateFunc;

        public IntPtr UserData {
            get {
                return _userData;
            }
            set {
                _userData = value;
                Write();
            }
        }
        private IntPtr _userData;
        #endregion

        internal CollisionHandler(IntPtr handle) {
            Handle = handle;
            Read();
            _defaultBeginFunc = rawHandler.beginFunc;
            _defaultPreSolveFunc = rawHandler.preSolveFunc;
            _defaultPostSolveFunc = rawHandler.postSolveFunc;
            _defaultSeperateFunc = rawHandler.separateFunc;
        }

        private void Read() {
            rawHandler = (RawCollisionHandler)Marshal.PtrToStructure(Handle, typeof(RawCollisionHandler));
            TypeA = rawHandler.typeA;
            TypeB = rawHandler.typeB;
        }

        private void Write() {
            if (BeginFunc != null) {
                rawHandler.beginFunc = Marshal.GetFunctionPointerForDelegate(
                    new RawDelegates.RawCollisionBeginFunc((arb, space, userData) => {
                        return BeginFunc(new Arbiter(arb), new Space(space), userData);
                    }));
            } else {
                rawHandler.beginFunc = _defaultBeginFunc;
            }

            if (PreSolveFunc != null) {
                rawHandler.preSolveFunc = Marshal.GetFunctionPointerForDelegate(
                    new RawDelegates.RawCollisionPreSolveFunc((arb, space, userData) => {
                        return PreSolveFunc(new Arbiter(arb), new Space(space), userData);
                    }));
            } else {
                rawHandler.preSolveFunc = _defaultPreSolveFunc;
            }

            if (PostSolveFunc != null) {
                rawHandler.postSolveFunc = Marshal.GetFunctionPointerForDelegate(
                    new RawDelegates.RawCollisionPostSolveFunc((arb, space, userData) => {
                        PostSolveFunc(new Arbiter(arb), new Space(space), userData);
                    }));
            } else {
                rawHandler.postSolveFunc = _defaultPostSolveFunc;
            }

            if (SeparateFunc != null) {
                rawHandler.separateFunc = Marshal.GetFunctionPointerForDelegate(
                    new RawDelegates.RawCollisionSeparateFunc((arb, space, userData) => {
                        SeparateFunc(new Arbiter(arb), new Space(space), userData);
                    }));
            } else {
                rawHandler.separateFunc = _defaultSeperateFunc;
            }

            Marshal.StructureToPtr(rawHandler, Handle, false);
        }
    }
}

using Chipmonk.CApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.CSharp {
    public class CollisionHandlerWrapper : ForeignReference {
        private RawCollisionHandler rawHandler;
        private ICollisionHandler handler;

        #region Properties
        public uint TypeA { get; private set; }
        public uint TypeB { get; private set; }
        #endregion

        internal CollisionHandlerWrapper(IntPtr handle, ICollisionHandler handler) {
            this.handler = handler;
            Handle = handle;
            Read();
            Write();
        }

        private void Read() {
            rawHandler = (RawCollisionHandler)Marshal.PtrToStructure(Handle, typeof(RawCollisionHandler));
            TypeA = rawHandler.typeA;
            TypeB = rawHandler.typeB;
        }

        private void Write() {
            rawHandler.beginFunc = Marshal.GetFunctionPointerForDelegate(
                new RawDelegates.RawCollisionBeginFunc((arb, space, userData) => {
                    return handler.BeginFunc(new Arbiter(arb), new Space(space), userData) ? (byte)1 : (byte)0;
                }));

            rawHandler.preSolveFunc = Marshal.GetFunctionPointerForDelegate(
                new RawDelegates.RawCollisionPreSolveFunc((arb, space, userData) => {
                    return handler.PreSolveFunc(new Arbiter(arb), new Space(space), userData) ? (byte)1 : (byte)0;
                }));

            rawHandler.postSolveFunc = Marshal.GetFunctionPointerForDelegate(
                new RawDelegates.RawCollisionPostSolveFunc((arb, space, userData) => {
                    handler.PostSolveFunc(new Arbiter(arb), new Space(space), userData);
                }));

            rawHandler.separateFunc = Marshal.GetFunctionPointerForDelegate(
                new RawDelegates.RawCollisionSeparateFunc((arb, space, userData) => {
                    handler.SeparateFunc(new Arbiter(arb), new Space(space), userData);
                }));

            Marshal.StructureToPtr(rawHandler, Handle, false);
        }
    }
}

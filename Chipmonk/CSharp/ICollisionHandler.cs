using System;

namespace Chipmonk.CSharp {
    public interface ICollisionHandler {
        bool BeginFunc(Arbiter arb, Space space, IntPtr userData);
        bool PreSolveFunc(Arbiter arb, Space space, IntPtr userData);
        void PostSolveFunc(Arbiter arb, Space space, IntPtr userData);
        void SeparateFunc(Arbiter arb, Space space, IntPtr userData);
    }
}

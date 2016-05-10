
using System;

namespace Chipmonk.CApi {
    public class Delegates {
        delegate void BodyVelocityFunc(IntPtr body, Vect gravity, double damping, double dt);
        delegate void BodyPositionFunc(IntPtr body, double dt);
    }
}

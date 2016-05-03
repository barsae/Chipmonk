using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class SimpleMotor {
        public IntPtr motor { get; private set; }

        public SimpleMotor(Body a, Body b, double rate) {
            motor = CP.SimpleMotorNew(a, b, rate);
        }

        // CP_EXPORT cpFloat cpSimpleMotorGetRate(const cpConstraint *constraint);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpGetRate")]
        public static extern double GetRate(IntPtr constraint);

        // CP_EXPORT void cpSimpleMotorSetRate(cpConstraint *constraint, cpFloat rate);
        [DllImport("chipmunk.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cpSetRate")]
        public static extern void SetRate(IntPtr constraint, double rate);

    }
}

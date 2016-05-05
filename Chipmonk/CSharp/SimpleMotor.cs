using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class SimpleMotor {
        public IntPtr Handle { get; set; }

        public SimpleMotor(Body a, Body b, double rate) {
            Handle = CP.SimpleMotorNew(a.Handle, b.Handle, rate);
        }

        public SimpleMotor(IntPtr handle) {
            Handle = handle;
        }

        public static SimpleMotor Alloc() {
            return new SimpleMotor(CP.SimpleMotorAlloc());
        }

        public static double GetRate(Constraint constraint) {
            return CP.SimpleMotorGetRate(constraint.Handle);
        }

        public SimpleMotor Init(Body a, Body b, double rate) {
            return new SimpleMotor(CP.SimpleMotorInit(Handle, a.Handle, b.Handle, rate));
        }

        public static Constraint New(Body a, Body b, double rate) {
            return new Constraint(CP.SimpleMotorNew(a.Handle, b.Handle, rate));
        }

        public static void SetRate(Constraint constraint, double rate) {
            CP.SimpleMotorSetRate(constraint.Handle, rate);
        }

    }
}

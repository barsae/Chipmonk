using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class SimpleMotor : Constraint {
        public double Rate {
            get {
                return CP.SimpleMotorGetRate(Handle);
            }
            set {
                CP.SimpleMotorSetRate(Handle, value);
            }
        }

        public SimpleMotor(Body a, Body b, double rate) {
            Handle = CP.SimpleMotorNew(a.Handle, b.Handle, rate);
        }
    }
}

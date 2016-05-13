using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class Constraint : IDisposable {
        internal IntPtr Handle { get; set; }

        #region Properties
        public Body BodyA {
            get {
                return new Body(CP.ConstraintGetBodyA(Handle));
            }
        }

        public Body BodyB {
            get {
                return new Body(CP.ConstraintGetBodyB(Handle));
            }
        }

        public bool CollideBodies {
            get {
                return CP.ConstraintGetCollideBodies(Handle);
            }
            set {
                CP.ConstraintSetCollideBodies(Handle, value);
            }
        }

        public double ErrorBias {
            get {
                return CP.ConstraintGetErrorBias(Handle);
            }
            set {
                CP.ConstraintSetErrorBias(Handle, value);
            }
        }

        public double Impulse {
            get {
                return CP.ConstraintGetImpulse(Handle);
            }
        }

        public double MaxBias {
            get {
                return CP.ConstraintGetMaxBias(Handle);
            }
            set {
                CP.ConstraintSetMaxBias(Handle, value);
            }
        }

        public double MaxForce {
            get {
                return CP.ConstraintGetMaxForce(Handle);
            }
            set {
                CP.ConstraintSetMaxForce(Handle, value);
            }
        }

        public Space Space {
            get {
                return new Space(CP.ConstraintGetSpace(Handle));
            }
        }

        public IntPtr UserData {
            get {
                return CP.ConstraintGetUserData(Handle);
            }
            set {
                CP.ConstraintSetUserData(Handle, value);
            }
        }

        public bool IsDampedRotarySpring {
            get {
                return CP.ConstraintIsDampedRotarySpring(Handle);
            }
        }

        public bool IsDampedSpring {
            get {
                return CP.ConstraintIsDampedSpring(Handle);
            }
        }

        public bool IsGearJoint {
            get {
                return CP.ConstraintIsGearJoint(Handle);
            }
        }

        public bool IsGrooveJoint {
            get {
                return CP.ConstraintIsGrooveJoint(Handle);
            }
        }

        public bool IsPinJoint {
            get {
                return CP.ConstraintIsPinJoint(Handle);
            }
        }

        public bool IsPivotJoint {
            get {
                return CP.ConstraintIsPivotJoint(Handle);
            }
        }

        public bool IsRatchetJoint {
            get {
                return CP.ConstraintIsRatchetJoint(Handle);
            }
        }

        public bool IsRotaryLimitJoint {
            get {
                return CP.ConstraintIsRotaryLimitJoint(Handle);
            }
        }

        public bool IsSimpleMotor {
            get {
                return CP.ConstraintIsSimpleMotor(Handle);
            }
        }

        public bool IsSlideJoint {
            get {
                return CP.ConstraintIsSlideJoint(Handle);
            }
        }
        #endregion Properties

        internal Constraint() {
            // Child class must sent Handle, or bad things will happen
        }

        internal Constraint(IntPtr handle) {
            Handle = handle;
        }

        public void Dispose() {
            CP.ConstraintFree(Handle);
        }
    }
}

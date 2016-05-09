using System;

namespace Chipmonk.CApi {
    public struct Vect {
        public double X;
        public double Y;

        public Vect(double x, double y) {
            X = x;
            Y = y;
        }

        public override string ToString() {
            return string.Format("({0}, {1})", X, Y);
        }

        public double Length() {
            return Math.Sqrt(X * X + Y * Y);
        }

        public static Vect operator*(Vect vect, double d) {
            return new Vect(vect.X * d, vect.Y * d);
        }

        public static Vect operator/(Vect vect, double d) {
            return new Vect(vect.X / d, vect.Y / d);
        }

        public static Vect operator-(Vect vect) {
            return new Vect(-vect.X, -vect.Y);
        }

        public static Vect Zero = new Vect(0.0, 0.0);
    }
}

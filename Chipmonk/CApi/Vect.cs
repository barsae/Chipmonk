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

        public static Vect operator+(Vect vect1, Vect vect2) {
            return new Vect(vect1.X + vect2.X, vect1.Y + vect2.Y);
        }

        public static Vect operator-(Vect vect1, Vect vect2) {
            return new Vect(vect1.X - vect2.X, vect1.Y - vect2.Y);
        }

        public static Vect operator-(Vect vect) {
            return new Vect(-vect.X, -vect.Y);
        }

        public static Vect operator*(Vect vect, double d) {
            return new Vect(vect.X * d, vect.Y * d);
        }

        public static Vect operator/(Vect vect, double d) {
            return new Vect(vect.X / d, vect.Y / d);
        }

        public static Vect Zero = new Vect(0.0, 0.0);
    }
}

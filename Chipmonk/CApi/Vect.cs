
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

        public static Vect Zero = new Vect(0.0, 0.0);
    }
}

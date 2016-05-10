
namespace Chipmonk.CApi {
    public struct ContactPointSet {
        public int Count;
        public Vect Normal;
        public ContactPoint[] Points;
    }

    public struct ContactPoint {
        public Vect PointA;
        public Vect PointB;
        public double Distance;
    }
}

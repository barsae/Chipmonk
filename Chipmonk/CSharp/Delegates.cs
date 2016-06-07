using Chipmonk.CApi;
using System;

namespace Chipmonk.CSharp {
    public class Delegates {
        public delegate void BodyVelocityFunc(Body body, Vect gravity, double damping, double dt);
        public delegate void BodyPositionFunc(Body body, double dt);
        public delegate bool CollisionBeginFunc(Arbiter arb, Space space, IntPtr userData);
        public delegate bool CollisionPreSolveFunc(Arbiter arb, Space space, IntPtr userData);
        public delegate void CollisionPostSolveFunc(Arbiter arb, Space space, IntPtr userData);
        public delegate void CollisionSeparateFunc(Arbiter arb, Space space, IntPtr userData);

        public delegate BB SpatialIndexBBFunc(IntPtr obj);
        public delegate void SpatialIndexIteratorFunc(IntPtr obj, IntPtr data);
        public delegate uint SpatialIndexQueryFunc(IntPtr obj1, IntPtr obj2, uint id, IntPtr data);
        public delegate double SpatialIndexSegmentQueryFunc(IntPtr obj1, IntPtr obj2, IntPtr data);

        public delegate void SpacePointQueryFunc(Shape shape, Vect point, double distance, Vect gradient, object data);
        public delegate void SpaceSegmentQueryFunc(Shape shape, Vect point, Vect normal, double alpha, object data);
        public delegate void SpaceBBQueryFunc(Shape shape, object data);
        public delegate void SpaceShapeQueryFunc(Shape shape, ContactPointSet points, object data);
    }
}

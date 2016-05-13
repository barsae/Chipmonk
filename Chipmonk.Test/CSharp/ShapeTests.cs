using Chipmonk.CApi;
using Chipmonk.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.Test.CSharp {
    [TestClass]
    public class ShapeTests {
        [TestMethod]
        public void CS_CircleShape_NewDispose_Works() {
            var space = new Space();
            var body = new Body(1.0, 1.0);
            var shape = new CircleShape(body, 1.0, Vect.Zero);
            space.AddBody(body);
            space.AddShape(shape);
            space.Step(1.0);
            space.RemoveShape(shape);
            shape.Dispose();
        }

        [TestMethod]
        public void CS_PolyShape_NewDispose_Works() {
            var space = new Space();
            var body = new Body(1.0, 1.0);
            var triangle = new Vect[] {
                new Vect(1, 0),
                new Vect(0, 0),
                new Vect(0, 1),
            };
            var shape = new PolyShape(body, triangle, 0);
            space.AddBody(body);
            space.AddShape(shape);
            space.Step(1.0);
            space.RemoveShape(shape);
            shape.Dispose();
        }

        [TestMethod]
        public void CS_BoxShape_NewDispose_Works() {
            var space = new Space();
            var body = new Body(1.0, 1.0);
            var shape = new BoxShape(2, 2, 0);
            space.AddBody(body);
            space.AddShape(shape);
            space.Step(1.0);
            space.RemoveShape(shape);
            shape.Dispose();
        }

        [TestMethod]
        public void CS_BoxShape2_NewDispose_Works() {
            var space = new Space();
            var body = new Body(1.0, 1.0);
            var bb = new BB(1, 2, 3, 4);
            var shape = new BoxShape(bb, 0);
            space.AddBody(body);
            space.AddShape(shape);
            space.Step(1.0);
            space.RemoveShape(shape);
            shape.Dispose();
        }

        [TestMethod]
        public void CS_SegmentShape_NewDispose_Works() {
            var space = new Space();
            var body = new Body(1.0, 1.0);
            var a = new Vect(0, 0);
            var b = new Vect(1, 1);
            var shape = new SegmentShape(body, a, b, 0);
            space.AddBody(body);
            space.AddShape(shape);
            space.Step(1.0);
            space.RemoveShape(shape);
            shape.Dispose();
        }
    }
}

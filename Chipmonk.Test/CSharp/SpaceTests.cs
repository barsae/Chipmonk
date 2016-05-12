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
    public class SpaceTests {
        [TestMethod]
        public void CS_Space_New_Works() {
            var space = new Space();
        }

        [TestMethod]
        public void CS_Space_AddRemoveBody_Works() {
            var space = new Space();
            var body = new Body(1.0, 1.0);
            space.AddBody(body);
            space.Step(1.0);
            space.RemoveBody(body);
        }

        [TestMethod]
        public void CS_Space_AddRemoveShape_Works() {
            var space = new Space();
            var body = new Body(1.0, 1.0);
            var shape = new CircleShape(body, 1.0, Vect.Zero);
            space.AddBody(body);
            space.AddShape(shape);
            space.Step(1.0);
            space.RemoveShape(shape);
            space.RemoveBody(body);
        }
    }
}

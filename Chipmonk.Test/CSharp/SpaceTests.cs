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

        [TestMethod]
        public void CS_Space_AddDefaultCollisionHandler_Works() {
            var space = new Space();
            var collisionHandler = space.AddDefaultCollisionHandler();

            bool beginFuncWasCalled = false;
            Body[] collisionBodies = null;
            collisionHandler.BeginFunc = (arb, collisionSpace, userData) => {
                beginFuncWasCalled = true;
                collisionBodies = arb.Bodies;
                return true;
            };

            var body1 = new Body(1.0, 1.0);
            body1.Position = new Vect(-10, 0);
            body1.Velocity = new Vect(10, 0);
            var shape1 = new CircleShape(body1, 1.0, Vect.Zero);
            space.AddBody(body1);
            space.AddShape(shape1);

            var body2 = new Body(1.0, 1.0);
            body2.Position = new Vect(10, 0);
            body2.Velocity = new Vect(-10, 0);
            var shape2 = new CircleShape(body2, 1.0, Vect.Zero);
            space.AddBody(body2);
            space.AddShape(shape2);

            for (int ii = 0; ii < 100; ii++) {
                space.Step(0.05);
            }

            Assert.IsTrue(beginFuncWasCalled);
            Assert.IsNotNull(collisionBodies);
            Assert.AreEqual(2, collisionBodies.Length);
            Assert.IsTrue(collisionBodies.Contains(body1));
            Assert.IsTrue(collisionBodies.Contains(body2));
        }
    }
}

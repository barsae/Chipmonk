using System;
using Chipmonk.CApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chipmonk.Test {
    [TestClass]
    public class SpaceTests {
        [TestMethod]
        public void Space_NewAndFree_Works() {
            var space = CP.SpaceNew();
            CP.SpaceStep(space, 1);
            CP.SpaceFree(space);
        }

        [TestMethod]
        public void Space_AllocInitDestroy_Works() {
            var space = CP.SpaceAlloc();
            CP.SpaceInit(space);
            CP.SpaceStep(space, 1);
            CP.SpaceDestroy(space);
        }

        [TestMethod]
        public void Space_AddRemoveBody_Works() {
            var space = CP.SpaceNew();
            var body = CP.BodyNew(1, 1);
            CP.SpaceAddBody(space, body);
            CP.SpaceRemoveBody(space, body);
            CP.BodyFree(body);
            CP.SpaceFree(space);
        }

        [TestMethod]
        public void Space_AddRemoveShape_Works() {
            var space = CP.SpaceNew();
            var body = CP.BodyNew(1, 1);
            var shape = CP.CircleShapeNew(body, 10, Vect.Zero);
            CP.SpaceAddShape(space, shape);
            CP.SpaceAddBody(space, body);
            CP.SpaceStep(space, 1);

            CP.SpaceRemoveShape(space, shape);
            CP.ShapeFree(shape);
            CP.SpaceRemoveBody(space, body);
            CP.BodyFree(body);
            CP.SpaceFree(space);
        }

        [TestMethod]
        public void Space_StepWithGravity_Works() {
            var space = CP.SpaceNew();
            var body = CP.BodyNew(1, 1);
            CP.SpaceAddBody(space, body);

            CP.SpaceSetGravity(space, new Vect(0, 10));
            CP.SpaceStep(space, 1);
            CP.SpaceStep(space, 1);

            var position = CP.BodyGetPosition(body);
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(10, position.Y);

            CP.SpaceRemoveBody(space, body);
            CP.BodyFree(body);
            CP.SpaceFree(space);
        }

        [TestMethod]
        public void Space_SetAndGetGravity_Work() {
            var space = CP.SpaceNew();
            var body = CP.BodyNew(1, 1);

            CP.SpaceSetGravity(space, new Vect(0, 10));
            var gravity = CP.SpaceGetGravity(space);
            Assert.AreEqual(0, gravity.X);
            Assert.AreEqual(10, gravity.Y);
        }

        [TestMethod]
        public void Space_SetAndGetIterations_Work() {
            var space = CP.SpaceNew();
            CP.SpaceSetIterations(space, 10);
            var iterations = CP.SpaceGetIterations(space);
            Assert.AreEqual(10, iterations);
            CP.SpaceFree(space);
        }

        [TestMethod]
        public void Space_SetAndGetUserData_Work() {
            var space = CP.SpaceNew();
            CP.SpaceSetUserData(space, new IntPtr(12));
            var userData = CP.SpaceGetUserData(space);
            Assert.AreEqual(12, CP.SpaceGetUserData(space).ToInt32());
            CP.SpaceFree(space);
        }
    }
}

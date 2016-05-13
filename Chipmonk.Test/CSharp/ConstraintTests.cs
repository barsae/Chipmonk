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
    public class ConstraintTests {
        [TestMethod]
        public void CS_DampedRotarySpring_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new DampedRotarySpring(body1, body2, 0, 1, 0.1);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }

        [TestMethod]
        public void CS_DampedSpring_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new DampedSpring(body1, body2, Vect.Zero, Vect.Zero, 1, 1, 0.5);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }

        [TestMethod]
        public void CS_GearJoint_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new GearJoint(body1, body2, 0, 1);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }

        [TestMethod]
        public void CS_GrooveJoint_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new GrooveJoint(body1, body2, Vect.Zero, Vect.Zero, Vect.Zero);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }

        [TestMethod]
        public void CS_PinJoint_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new PinJoint(body1, body2, Vect.Zero, Vect.Zero);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }

        [TestMethod]
        public void CS_PivotJoint_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new PivotJoint(body1, body2, Vect.Zero);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }

        [TestMethod]
        public void CS_PivotJoint2_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new PivotJoint(body1, body2, Vect.Zero, Vect.Zero);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }

        [TestMethod]
        public void CS_RatchetJoint_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new RatchetJoint(body1, body2, 0, 2);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }

        [TestMethod]
        public void CS_RotaryLimitJoint_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new RotaryLimitJoint(body1, body2, 0, 1);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }

        [TestMethod]
        public void CS_SimpleMotor_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new SimpleMotor(body1, body2, 1);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }

        [TestMethod]
        public void CS_SlideJoint_NewDispose_Works() {
            var space = new Space();
            var body1 = new Body(1.0, 1.0);
            var body2 = new Body(1.0, 1.0);
            var constraint = new SlideJoint(body1, body2, Vect.Zero, Vect.Zero, 0, 1);
            space.AddBody(body1);
            space.AddBody(body2);
            space.AddConstraint(constraint);

            space.Step(1.0);
            space.RemoveConstraint(constraint);
            constraint.Dispose();
        }
    }
}

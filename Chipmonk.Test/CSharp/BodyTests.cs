using Chipmonk.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.Test.CSharp {
    [TestClass]
    public class BodyTests {
        [TestMethod]
        public void CS_Body_NewDispose_Works() {
            var space = new Space();
            var body = new Body(1.0, 1.0);
            space.AddBody(body);
            space.Step(1.0);
            space.RemoveBody(body);
            body.Dispose();
        }

        [TestMethod]
        public void CS_StaticBody_NewDispose_Works() {
            var space = new Space();
            var body = new StaticBody();
            space.AddBody(body);
            space.Step(1.0);
            space.RemoveBody(body);
            body.Dispose();
        }

        [TestMethod]
        public void CS_KinematicBody_NewDispose_Works() {
            var space = new Space();
            var body = new KinematicBody();
            space.AddBody(body);
            space.Step(1.0);
            space.RemoveBody(body);
            body.Dispose();
        }
    }
}

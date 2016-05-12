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
            var body = new Body(1.0, 1.0);
            body.Dispose();
        }
    }
}

using Chipmonk.CApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.CSharp {
    public class KinematicBody : Body {
        public KinematicBody() : base(CP.BodyNewKinematic()) {
        }
    }
}

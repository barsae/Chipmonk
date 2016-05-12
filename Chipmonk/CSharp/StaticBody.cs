using Chipmonk.CApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.CSharp {
    public class StaticBody : Body {
        public StaticBody() : base(CP.BodyNewStatic()) {
        }
    }
}

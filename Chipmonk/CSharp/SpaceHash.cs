using System;
using System.Runtime.InteropServices;
using Chipmonk.CApi;

namespace Chipmonk.CSharp {
    public class SpaceHash : ForeignReference {
        public SpaceHash(double celldim, int cells, IntPtr bbfunc, IntPtr staticIndex) {
            Handle = CP.SpaceHashNew(celldim, cells, bbfunc, staticIndex);
        }

        public void Resize(double celldim, int numcells) {
            CP.SpaceHashResize(Handle, celldim, numcells);
        }
    }
}

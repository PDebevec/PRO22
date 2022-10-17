using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal class Psiho : Mutant
    {
        private int iQ;
        private int številoUporabeMoči;

        public int IQ { get => iQ; set => iQ = value; }
        public int ŠteviloUporabeMoči { get => številoUporabeMoči; set => številoUporabeMoči = value; }

        public override int kvocientNevarnosti()
        {
            return Stopnja * IQ * ŠteviloUporabeMoči;
        }
    }
}

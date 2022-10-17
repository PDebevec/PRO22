using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal class Psiho : Mutant
    {
        public int IQ;
        public int ŠteviloUporabeMoči;
        public override int kvocientNevarnosti()
        {
            return Stopnja * IQ * ŠteviloUporabeMoči;
        }
    }
}

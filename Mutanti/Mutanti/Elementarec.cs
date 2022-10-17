using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal class Elementarec : Mutant
    {
        public int Področje;
        public override int kvocientNevarnosti()
        {
            return Stopnja * Področje;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal class Fizikalec : Mutant
    {
        public int IQ;
        public int Moč;
        public override int kvocientNevarnosti()
        {
            return Stopnja * IQ * Moč;
        }
    }
}

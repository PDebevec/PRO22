using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal class Fizikalec : Mutant
    {
        private int iQ;
        private int moč;

        public int IQ { get => iQ; set => iQ = value; }
        public int Moč { get => moč; set => moč = value; }

        public override int kvocientNevarnosti()
        {
            return Stopnja * IQ * Moč;
        }
    }
}

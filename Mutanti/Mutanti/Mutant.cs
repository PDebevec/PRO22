using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal abstract class Mutant:IPrikazovalnik
    {
        private string ime;
        private int stopnja;

        public string Ime { get => ime; set => ime = value; }
        public int Stopnja { get => stopnja; set => stopnja = value; }

        public void prikažiInformacije()
        {
            Console.WriteLine("Mutant " + ime + " ima kvocient nevarnosti " + kvocientNevarnosti());
        }
        public abstract int kvocientNevarnosti();
    }
}

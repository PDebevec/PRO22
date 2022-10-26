using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    internal class Karta
    {
        public Barve Barva { get; set; }
        public Vrednosti Vrednost { get; set; }
        public string Ime { get; set; }

        public Karta(Barve b, Vrednosti v)
        {
            Barva = b;
            Vrednost = v;
            Ime = v + " " + b;
        }
    }
}

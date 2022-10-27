using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojGoFish
{
    class Karta : KartaID
    {
        string ime;
        public Karta() { }
        public Karta(Simbol s, Vrednost v) : base(s, v)
        {
            ime = base.ToString();
        }
        public string Ime() => ime;
    }
}

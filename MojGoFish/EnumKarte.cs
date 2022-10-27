using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojGoFish
{
    enum Simbol { križ, pika, srce, karo }
    enum Vrednost { As = 1, Dva, Tri, Štiri, Pet, Šest, Sedem, Osem, Devet, Deset, Janez, Dama, Kralj }
    class KartaID
    {
        protected Simbol simbol { get; set; }
        protected Vrednost vrednost { get; set; }
        public KartaID() { }
        public KartaID(Simbol s, Vrednost v) { simbol = s; vrednost = v; }
        public static bool operator ==(KartaID a, KartaID b)
        {
            if (a.vrednost == b.vrednost)
                return true;
            return false;
        }
        public static bool operator !=(KartaID a, KartaID b)
        {
            if (a.vrednost != b.vrednost)
                return true;
            return false;
        }
        public override string ToString() => simbol.ToString() + " " + vrednost.ToString();
    }
}

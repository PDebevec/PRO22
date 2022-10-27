using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojGoFish
{
    class Primerjava : IComparer<Karta>
    {

        public int Compare(Karta x, Karta y)
        {
            if (x.vrednost < y.vrednost)
                return -1;
            if (x.vrednost > y.vrednost)
                return 1;
            if (x.simbol < y.simbol)
                return -1;
            if (x.simbol > y.simbol)
                return 1;
            return 0;

        }
    }
}

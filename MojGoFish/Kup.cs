using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojGoFish
{
    class Kup
    {
        Random r = new Random();
        List<Karta> kup;
        int številoKart;

        public Kup()
        {
            kup = new List<Karta>();
            foreach (Simbol s in Enum.GetValues(typeof(Simbol)))
                foreach (Vrednost v in Enum.GetValues(typeof(Vrednost)))
                    kup.Add(new Karta(s, v));
        }
        public Kup(int num) => kup = new List<Karta>(num);
        public int ŠteviloKart { get => kup.Count; }

        public void add(Karta k) => kup.Add(k);
        public Karta Deli(KartaID k)
        {
            for (int i = 0; i < kup.Count; i++)
            {
                if (kup[i] == k)
                {
                    Karta temp = kup[i];
                    kup.RemoveAt(i);
                    return temp;
                }
            }
            throw new IndexOutOfRangeException();
        }
        public void sort() => kup.Sort(new Primerjava());
        public void mešaj()
        {
            Karta temp = new Karta();
            int a, b;
            for (int i = 0; i < kup.Count/2; i++)
            {
                a = r.Next(kup.Count);
                b = r.Next(kup.Count);
                temp = kup[a];
                kup[a] = kup[b];
                kup[b] = temp;
            }
        }
    }
}

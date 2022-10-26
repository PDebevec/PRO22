using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    internal class Kup
    {
        List<Karta> kup;
        Random r = new Random();

        public Kup()
        {
            kup = new List<Karta>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    kup.Add(new Karta((Barve)i, (Vrednosti)j));
                }
            }
        }
        public Kup(int size) => kup = new List<Karta>(size);
        public Kup(IEnumerable<Karta> start)
            => kup = new List<Karta>(start);
        
        public void add(Karta nova) => kup.Add(nova);
        public int count
        {
            get { return kup.Count; }
        }
        public void sort() => kup.Sort(new Primerjava());
        public List<string> ImenaKart()
        {
            List<string> imena = new List<string>();
            foreach (Karta i in kup)
                imena.Add(i.Ime);
            return imena;
        }
        public Karta Deli(int index)
        {
            Karta x = kup[index];
            kup.RemoveAt(index);
            return x;
        }
        public void mešaj()
        {
            for (int i = 0; i < kup.Count; i++)
            {
                int x = r.Next(kup.Count);
                int y = r.Next(kup.Count);
                Karta temp = kup[x];
                kup[x] = kup[y];
                kup[y] = temp;
            }
        }
    }
}

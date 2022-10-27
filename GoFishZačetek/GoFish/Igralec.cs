using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    internal class Igralec
    {
        private string ime; //ime igralca
        public string Ime
        {
            get { return ime; }
        }
        private Random random;
        private Kup roka; //karte, ki jih ima igralec v roki
        private TextBox textNaFormi; //vnosno polje za izpis rezultatov
        public Igralec(string i, Random r, TextBox t)
        {
            //Konstruktor inicializira atribute Igralca
            //v vnosno polje doda tekst "Joe se je pridružil igri" in prehod
            //v novo vrstico
            ime = i;
            random = r;
            textNaFormi = t;
            textNaFormi.Text += ime + " se je pridružil igri" + Environment.NewLine;
            roka = new Kup();
        }

        public IEnumerable<Vrednosti> IzločiKomplete()
        {
            //pregleda vseh 13 možnih vrednosti kart
            //ugotovi koliko kart s to vrednostjo ima igralec v roki
            // če ima 4 karte te vrednosti je to komplet, ki ga doda seznamu in karte
            //odstrani iz roke
            List<Vrednosti> kompleti = new List<Vrednosti>();
            for (int i = 1; i <= 13; i++)
            {
                Vrednosti v = (Vrednosti)i;
                int koliko = 0;
                for (int k = 0; k < roka.Count; k++)
                {
                    if (roka.Peek(k).Vrednost == v)
                        koliko++;
                }
                if (koliko == 4)
                {
                    kompleti.Add(v);
                    roka.PullOutValues(v);
                }
            }
            return kompleti;
        }
        //vrne naključno vrednost, a mora biti iz roke igralca
        //če bo igralec računalnik bo izbral naključno vrednost za spraševanje
        public Vrednosti DobiNaključnoVrednost() => roka.Peek(random.Next(roka.Count)).Vrednost;
        public Kup ImašKakšno(Vrednosti v)
        {
            //Nasprotnik te sprašuje ali imaš kakšno karto določene vrednosti
            // če jo imaš s pomočjo PullOutValues(3) odstrani karto iz svoje roke. Dodaj
            // vrstico v vnosno polje "Joe ima 3 šestice"
            Kup imam = roka.PullOutValues(v);
            textNaFormi.Text += ime + " ima " + imam.Count + " " + v + Environment.NewLine;
            return imam;
        }
        public void VprašajZaKarto(List<Igralec> i, int mojInd, Kup talon, Vrednosti v)
        {
            //Tu ti sprašuješ druge igralce ali imajo karto določene vrednosti
            textNaFormi.Text += ime + " sprašuje če ima kdo " + v + Environment.NewLine;
            int danekarteskupaj = 0;
            for (int j = 0; j < i.Count; j++)
            {
                if (j != mojInd)
                {
                    Igralec ig = i[j];
                    Kup danekarte = ig.ImašKakšno(v);
                    danekarteskupaj += danekarte.Count;
                    while(danekarte.Count > 0)
                    {
                        roka.Add(danekarte.Deli());
                    }
                }
            }
            //vsi so mi dali vse karte
            if (danekarteskupaj == 0 && talon.Count > 0)
            {
                roka.Add(talon.Deli());
                textNaFormi.Text += ime + " mora potegniti kato iz talona" + Environment.NewLine;
            }
        }
        public void VprašajZaKarto(List<Igralec> i, int mojIndeks, Kup talon)
        {
            //Overload zgornje metode, kjer je vrednost naključna, rač. Igralec sprašuje
            Vrednosti nak = DobiNaključnoVrednost();
            VprašajZaKarto(i, mojIndeks, talon, nak);
        }
        public int ŠtevecKart { get { return roka.Count; } }
        public void VzemiKarto(Karta k)
        {
            roka.Add(k);
        }
        public IEnumerable<string> Imena()
        {
            return roka.ImenaKart();
        }
        public Karta Peek(int št)
        {
            return roka.Peek(št);
        }
        public void SortRoka()
        {
            roka.Sort();
        }

    }
}

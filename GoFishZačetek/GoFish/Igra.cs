using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    internal class Igra
    {
        private List<Igralec> igralci;
        private Dictionary<Vrednosti, Igralec> kompleti;
        private Kup talon;
        private TextBox textNaFormi;
        Random r;
        public Igra(string i, IEnumerable<string> nasprotniki, TextBox txtIgra)
        {
            r = new Random();
            textNaFormi = txtIgra;
            igralci = new List<Igralec>();
            igralci.Add(new Igralec(i, r, textNaFormi));
            foreach (string k in nasprotniki)
                igralci.Add(new Igralec(k, r, textNaFormi));
            kompleti = new Dictionary<Vrednosti, Igralec>();
            talon = new Kup(); //ne pozabi, če kličem brez parametrov
                              // imam tu vse možne karte
            Deli();
            igralci[0].SortRoka();
        }
        private void Deli()
        {
            //Tukaj se igra začne. Premešaj kup daj vsakemu igralcu 5 kart
            talon.Mešaj();
            foreach (Igralec i in igralci)
            {
                for (int j = 0; j < 5; j++)
                {
                    i.VzemiKarto(talon.Deli(r.Next(talon.Count)));
                }
                // nato kliči metodo IzločiKomplete
                i.IzločiKomplete();
            }
        }
        public bool IgrajEnKrog(int izbranaKarta)
        {
            //metoda vrača true, če je konec igre, false sicer
            if (talon.Count == 0)
                return true;
            else
            {
                //iščemo izbrano karto, najprej igra igralec 0, nato vsi ostali
                igralci[0].VprašajZaKarto(igralci, 0, talon, (Vrednosti)izbranaKarta);
                for (int i = 1; i < igralci.Count; i++)
                {
                    igralci[i].VprašajZaKarto(igralci, i, talon);
                    igralci[i].IzločiKomplete();
                }
                if (talon.Count == 0)
                    return true;
                return false;
            }
            //takoj, ko dobimo morebitne karte od igralcev, igra preveri, če je kaj
            //kompletov, komplete odstrani, po potrebi dodeli igralcu nove karte
            //če zmanjka kart je igre konec
        }

        internal IEnumerable<string> KarteIgralca()
        {
            throw new NotImplementedException();
        }

        internal string OpišiKomplete()
        {
            throw new NotImplementedException();
        }

        internal string OpišiVRokah()
        {
            throw new NotImplementedException();
        }

        internal string ImeZmagovalca()
        {
            throw new NotImplementedException();
        }
    }
}

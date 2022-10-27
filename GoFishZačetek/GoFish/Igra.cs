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
            foreach (Vrednosti iv in Enum.GetValues(typeof(Vrednosti)))
            {
                kompleti.Add(iv, null);
            }
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
        public bool IzločiKomplete(Igralec ig)
        {
            //izloči komplete za posameznega igralca in vrne vrednost true
            //če je igralec ostal brez kart
            foreach (Igralec i in igralci)
            {
                i.IzločiKomplete();
            }
            ig.IzločiKomplete();
            if (ig.ŠtevecKart == 0)
                return true;
            return false;
        }
        internal IEnumerable<string> KarteIgralca()
        {
            //vrni seznam imen igralcev
            List<string> imenai = new List<string>();
            foreach (Igralec i in igralci)
            {
                imenai.Add(i.Ime);
            }
            return imenai;
        }

        internal string OpišiKomplete()
        {
            //vrni niz, v katerem so imena igralcev in kompleti kart
            string temp = "";
            for (int i = 0; i < igralci.Count; i++)
            {
                foreach (Vrednosti j in Enum.GetValues(typeof(Vrednosti)))
                {
                    if(kompleti[j] != null)
                    {
                        if (kompleti[j].Ime == igralci[i].Ime)
                        {
                            temp += igralci[i].Ime + " komplet: " + kompleti[j] + "";
                        }
                    }
                }
                temp += Environment.NewLine;
            }
            return temp;
        }

        internal string OpišiVRokah()
        {
            //izpiši imena igralcev in število kart v rokah
            //izpiši tudi koliko kart je v talonu, opis vrni kot spremenljivko tipa string
            string temp = "";
            for (int i = 0; i < igralci.Count; i++)
            {
                temp += igralci[i].Ime + " " + igralci[i].ŠtevecKart + Environment.NewLine;
            }
            return temp;
        }

        internal string ImeZmagovalca()
        {
            //Metoda se kliče na koncu igre. Uporablja svojo strukturo - slovar, v
            //kateri je število vseh kompletov posameznega igralca
            //Najprej pregleda z zanko foreach število kompletov in jih doda v zbirko zmagovalcev

            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Vrednosti v in kompleti.Keys)
            {
                string ime = kompleti[v].Ime;
                if (winners.ContainsKey(ime))
                    winners[ime]++;
                else
                    winners.Add(ime, 1);
            }
            //Nato poišče največjo vrednost kompletov
            int mostBooks = 0;
            foreach (string name in winners.Keys)
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];
            bool tie = false;
            string winnerList = "";
            //določi kateri od igralcev ima to vrednost, lahko jih je več
            foreach (string name in winners.Keys)
                if (winners[name] == mostBooks)
                {
                    if (!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " in ";
                        tie = true;
                    }
                    winnerList += name;
                }
            winnerList += " z " + mostBooks + " kompleti";
            if (tie)
                return "Neodločeno " + winnerList;
            else
                return winnerList;

        }
    }
}

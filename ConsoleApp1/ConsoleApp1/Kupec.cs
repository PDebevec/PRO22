using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kupec
    {
        protected string ime;
        protected decimal stanje;

        public string Ime { get => ime; set => ime = value; }
        public decimal Stanje { get => stanje; } //ne moreš spreminjat izven razreda
        public void beležiPlačilo(decimal plačila)
        {
            stanje -= plačila;
        }
        public virtual void beležiKlic(int min, TipKlica tip)
        {
            switch (tip)
            {
                case TipKlica.Stacionarno:
                    stanje += min * 0.12m;
                    break;
                case TipKlica.Mobilo:
                    stanje += min * 0.03m;
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            return ime + " dolguje " + stanje + " dinarju";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kupec
    {
        private string ime;
        private decimal stanje;

        public string Ime { get => ime; set => ime = value; }
        public decimal Stanje { get => stanje; } //ne moreš spreminjat izven razreda
        public void beležiPlačilo(decimal plačila)
        {
            stanje -= plačila;
        }
        public void beležiKlic(int min, TipKlica tip)
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
    }
}

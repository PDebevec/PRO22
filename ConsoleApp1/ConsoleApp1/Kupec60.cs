using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kupec60:Kupec
    {
        private int višjaTarifaPorabljeno;
        public override void beležiKlic(int min, TipKlica tip)
        {
            switch (tip)
            {
                case TipKlica.Stacionarno:
                    stanje += min * 0.12m;
                    break;
                case TipKlica.Mobilo:
                    int vMinute, nMinute;
                    int šeVMinute = (višjaTarifaPorabljeno < 60) ? 60 - višjaTarifaPorabljeno : 0;
                    if(min > šeVMinute) //v tem primeru dve tarifi
                    {
                        vMinute = šeVMinute;
                        nMinute = min - vMinute;
                    }
                    else
                    {
                        vMinute = min;
                        nMinute = 0;
                    }
                    stanje += vMinute * 0.035m + nMinute * 0.01m;
                    višjaTarifaPorabljeno += vMinute;
                    break;
                default:
                    break;
            }
        }
    }
}

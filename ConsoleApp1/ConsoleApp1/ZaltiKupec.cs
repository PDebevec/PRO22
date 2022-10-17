using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ZaltiKupec : Kupec
    {
        public override void beležiKlic(int min, TipKlica tip)
        {
            base.beležiKlic(min, tip);
            stanje *= 0.9m;
        }
    }
}

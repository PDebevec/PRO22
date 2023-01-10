using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entities en = new Entities();
            //var kupci = from k in en.KUPECs select new { k.KUP_IME, k.KUP_PRIIMEK };
            //foreach (var i in kupci)
            //{
            //    Console.WriteLine(i.KUP_IME + " " + i.KUP_PRIIMEK);
            //}
            //Console.WriteLine(kupci.Count());
            //var opisi = from p in en.PRODUKTs select p.P_OPIS;
            //foreach (var i in opisi)
            //{
            //    Console.WriteLine(i);
            //}
            //var vseprodukti = from v in en.VRSTICAs
            //                  join p in en.PRODUKTs
            //                  on v.P_KODA equals p.P_KODA
            //                  select new { v.RAČ_ID, v.VRS_ŠT, p.P_OPIS };
            //foreach (var i in vseprodukti)
            //{
            //    Console.WriteLine(i.RAČ_ID + " " + i.VRS_ŠT + " " + i.P_OPIS);
            //}
            var vrstice = from v in en.VRSTICAs
                          join p in en.PRODUKTs
                          on v.P_KODA equals p.P_KODA
                          group v by v.RAČ_ID into g
                          select new {  };
            Console.ReadLine();
        }
    }
}

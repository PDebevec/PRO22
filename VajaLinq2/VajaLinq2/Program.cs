using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VajaLinq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BazaVEntities be = new BazaVEntities();
            //
            //DateTime dt = DateTime.Parse("20.1.2004");
            //var mincenaProdikt = from p in be.PRODUKT
            //                     where DbFunctions.TruncateTime(p.P_DATUM) == dt
            //                     select new { p.P_OPIS, p.P_ZALOGA, p.P_MIN, p.P_CENA };
            //foreach (var i in mincenaProdikt)
            //{
            //    Console.WriteLine(i.P_OPIS + " " + i.P_ZALOGA + " " + i.P_MIN + " " + i.P_CENA);
            //}
            //
            //dt = DateTime.Now.AddYears(1);
            //var zapadlost = from p in be.PRODUKT
            //                select new { p.P_OPIS, p.P_ZALOGA, p.P_DATUM, ZAPADLOST = dt.Date };
            //foreach (var i in zapadlost)
            //{
            //    Console.WriteLine(i.P_OPIS + " " + i.P_ZALOGA + " " + i.P_DATUM + " " + i.ZAPADLOST);
            //}
            //
            //dt = DateTime.Parse("15.1.2004");
            //var cenapaDatum = from p in be.PRODUKT
            //                  where p.P_CENA < 50
            //                  where DbFunctions.TruncateTime(p.P_DATUM) >= dt
            //                  select new { p.P_OPIS, p.P_ZALOGA, p.P_MIN, p.P_CENA };
            //foreach (var p in cenapaDatum)
            //{
            //    Console.WriteLine(p.P_OPIS + " " + p.P_ZALOGA + " " + p.P_MIN + " " + p.P_CENA);
            //}
            //
            //var smith = be.DOBAVITELJ
            //    .Where(d => d.D_KONTAKT.Contains("Smith"))
            //    .Select(d => d);
            //foreach (var d in smith)
            //{
            //    Console.WriteLine(d.D_KONTAKT);
            //}
            //
            //var poduktZaloga = be.PRODUKT.Where(p => p.P_ZALOGA < be.PRODUKT.Min(m => m.P_ZALOGA)*2).Select(s => s.DOBAVITELJ);
            //foreach (var i in poduktZaloga)
            //{
            //    if(i != null)
            //        Console.WriteLine(i.D_IME);
            //}
            //
            //var disdobavitelj = be.DOBAVITELJ.Where(d => d.PRODUKT.Select(s => s.D_KODA).Contains(d.D_KODA)).Distinct();
            //foreach (var i in disdobavitelj)
            //{
            //    Console.WriteLine(i.D_KODA);
            //}
            //
            //var disdobavitelj = be.DOBAVITELJ.Where(d => !d.PRODUKT.Select(s => s.D_KODA).Contains(d.D_KODA)).Distinct();
            //foreach (var i in disdobavitelj)
            //{
            //    Console.WriteLine(i.D_KODA);
            //}
            //
            //var stanje = be.KUPEC.Sum(s => s.KUP_STANJE);
            //Console.WriteLine(stanje);
            ////
            //var celacena = be.PRODUKT.Sum(s => s.P_CENA * s.P_ZALOGA);
            //Console.WriteLine(celacena);
            //
            var produktodDobavitelja = be.DOBAVITELJ.GroupBy(g => g.D_KODA).Select(s => s).Count();
            foreach (var i in produktodDobavitelja)
            {
                if(i != null)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

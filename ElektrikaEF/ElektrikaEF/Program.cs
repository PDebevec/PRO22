using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElektrikaEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElektrikaEntities ee = new ElektrikaEntities();
            var meritvečm = from p in ee.Meritve select p;
            var lamdačm = ee.Meritve.Select(m => m);
            //foreach (var i in lamdačm)
            //{
            //    Console.WriteLine(i.ZapisČas + " " + i.kW1);
            //}
            DateTime dt = DateTime.Parse("18.8.2013");
            var datum = from p in ee.Meritve where DbFunctions.TruncateTime(p.ZapisČas.Value) == dt select p;
            //Console.WriteLine(datum.Count());
            //foreach (var i in datum)
            //{
            //    Console.WriteLine(i.ZapisČas + " " + i.kW1);
            //}
            var avg = ee.Meritve.Where(čas => DbFunctions.TruncateTime(čas.ZapisČas.Value) == dt).Average(a => a.kW1 + a.kW2 + a.kW3);
            var max = ee.Meritve.Where(čas => DbFunctions.TruncateTime(čas.ZapisČas.Value) == dt).Max(a => a.kW1 + a.kW2 + a.kW3);
            var min = ee.Meritve.Where(čas => DbFunctions.TruncateTime(čas.ZapisČas.Value) == dt).Min(a => a.kW1 + a.kW2 + a.kW1);
            //Console.WriteLine("avg " + avg + " max " + max + " min " + min);
            var mpoh = from p in ee.Meritve
                      where DbFunctions.TruncateTime(p.ZapisČas.Value) == dt
                      group p by p.ZapisČas.Value.Hour into g
                      select new { ura = g.Key, moč = g.Average(e => e.kW1 + e.kW2 + e.kW3) };
            //foreach (var i in mpoh)
            //{
            //    Console.WriteLine(i.ura+1 + " " + i.moč);
            //}
            var mpom = from p in ee.Meritve
                       where DbFunctions.TruncateTime(p.ZapisČas.Value) == dt
                       let ura = p.ZapisČas.Value.Hour
                       let mi = p.ZapisČas.Value.Minute
                       let quarter = mi / 15
                       group p by new { ura, quarter } into g
                       orderby g.Key
                       select new { ura = g.Key.ura, četrt = g.Key.quarter, moč = g.Average(e => e.kW1 + e.kW2 + e.kW3) };
            foreach (var i in mpom)
            {
                Console.WriteLine(i.ura+1 + " " + i.četrt + " " + i.moč);
            }
            Console.ReadLine();
        }
    }
}

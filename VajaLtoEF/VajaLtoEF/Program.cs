using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaLtoEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adw adw = new Adw();
            var artikli = from p in adw.Product where p.ProductNumber.StartsWith("FR") select p.Name;
            adw.Database.Log = Console.WriteLine;
            //foreach (var i in artikli)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine(artikli.Count() + " produktov");
            ////posodabljannje
            var pricechange = (from p in adw.Product where p.ProductNumber == "FR-R92B-58" select p).SingleOrDefault();
            //if (pricechange != null)
            //{
            //    pricechange.ListPrice = 1500;
            //}
            //adw.SaveChanges();
            //Console.WriteLine(pricechange.Name + " " + pricechange.ListPrice + " " + pricechange.ProductNumber);
            ////vsavljanje
            ProductCategory pc = new ProductCategory();
            pc.Name = "Moja nova kategorija";
            pc.ModifiedDate = DateTime.Now;
            //adw.ProductCategory.Add(pc);
            //adw.SaveChanges();
            ProductCategory c = (from p in adw.ProductCategory where p.Name == "Moja nova kategorija" select p).SingleOrDefault();
            //adw.ProductCategory.Remove(c);
            //adw.SaveChanges();
            
            Console.ReadLine();
        }
    }
}

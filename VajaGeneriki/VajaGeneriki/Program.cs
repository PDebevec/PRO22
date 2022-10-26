using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaGeneriki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PovezavaList<int, string> x = new PovezavaList<int, string>();
            x.Dodaj(1, "lalala");
            x.Dodaj(5, "cccc");
            x.Dodaj(2, "mijav");
            string r = x.Najdi(5);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}

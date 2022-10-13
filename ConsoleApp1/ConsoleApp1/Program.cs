using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kupec janez = new Kupec();
            janez.Ime = "Janze novak";
            janez.beležiKlic(10, TipKlica.Stacionarno);
            Console.WriteLine(janez.Ime + " dolguje " + janez.Stanje);
            Kupec alenka = new Kupec();
            alenka.Ime = "alenka novak";
            alenka.beležiKlic(10, TipKlica.Mobilo);
            Console.WriteLine(alenka.Ime + " dolguje " + alenka.Stanje);
            Console.ReadLine();
        }
    }
}

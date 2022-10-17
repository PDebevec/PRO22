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
            //Kupec
            Kupec janez = new Kupec();
            janez.Ime = "Janze novak";
            janez.beležiKlic(10, TipKlica.Stacionarno);
            Console.WriteLine(janez.Ime + " dolguje " + janez.Stanje);
            Console.WriteLine("get type " + janez.GetType());
            Console.WriteLine("to string " + janez.ToString());

            //Kupec60
            Kupec /*<- je lahko tudi Kupec -> tam ostane kupec60*/ alenka = new Kupec60(); //lahko gre gor v hirarhiji dol pa ne
            //^če Kupec potli kliče funkcije od razreda Kupec ne Kupec60
            alenka.Ime = "janez novak";
            alenka.beležiKlic(100, TipKlica.Mobilo);
            Console.WriteLine(alenka.Ime + " dolguje " + alenka.Stanje);
            Console.WriteLine("get type " + alenka.GetType());
            Console.WriteLine("to string " + alenka.ToString());

            Kupec[] vsiKupci = new Kupec[2];
            vsiKupci[0] = new Kupec();
            vsiKupci[1] = new ZaltiKupec();
            Console.ReadLine();
        }
    }
}

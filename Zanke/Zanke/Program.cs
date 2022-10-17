using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zanke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vsota = 0;
            Random r = new Random();
            for(int k=0;k<10;k++)
            {
                //Console.WriteLine("vnesi stevilo");
                //int st = int.Parse(Console.ReadLine());
                int a = r.Next(100);
                Console.WriteLine("izmislil sem si "+a);
                vsota = vsota + a;
                

            }
            Console.WriteLine("vosta je: "+vsota);
            //izmisli si 10 stevil 0-100
            //izracunaj in izpisi minimum
            int min = 101;
            for(int s=0; s < 10; s++)
            {
                int b = r.Next(100);
                Console.WriteLine("izmislil sem si " + b);
                if (b < min)
                {
                    min = b;
                }
            }
            Console.WriteLine("njamajsi je " + min);
            Console.ReadLine();
        }
    }
}

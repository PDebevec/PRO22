using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            for (int k = 1; k <= 10; k++)
            {
                a.Add(k);
            }
            int vsota = Izračunaj(a);
            Console.WriteLine("Vsota je " + vsota);
            Console.ReadLine();
        }

        private static int Izračunaj(List<int> a)
        {
            if (a.Count != 0)
            {
                int x = a[0];
                a.RemoveAt(0);
                return x + Izračunaj(a);
            }
            else return 0;
        }
    }
}

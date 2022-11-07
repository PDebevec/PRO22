using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KličiMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imedatoteke = "C:\\D disk\\git\\PRO22\\KličiMe\\KličiMe\\klici.txt";
            Bralec bralec = new Bralec();
            try
            {
                bralec.Odpri(imedatoteke);
                for (int i = 0; i < bralec.nOseb; i++)
                {
                    bralec.obravnavajNaslednjega();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("datoteka " + imedatoteke + " ne obstaja");
            }
            catch (KličiMeException k)
            {
                Console.WriteLine("datoteka ima napačno strukturo");
                Console.WriteLine(k.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("neznana napaka " + e.Message);
            }
            Console.ReadLine();
        }
    }
}

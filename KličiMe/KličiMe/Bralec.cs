using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KličiMe
{
    internal class Bralec
    {
        FileStream fs;
        StreamReader sr; //iz katere datoteke
        uint st; //koliko oseb naj kličem

        public void Odpri(string fileLocation)
        {
            fs = new FileStream(fileLocation, FileMode.Open);
            sr = new StreamReader(fs);
            try
            {
                string prvaVrstica = sr.ReadLine();
                st = uint.Parse(prvaVrstica);
            }
            catch (FormatException)
            {
                Console.WriteLine("Prvo število v datoteki ni število oz. pozitivno");
            }
        }
        public uint nOseb { get { return st; } } //getter metoda za splemenljivko st

        public void obravnavajNaslednjega()
        {
            try
            {
                string ime = sr.ReadLine();
                if (ime == null)
                {
                    throw new KličiMeException("Ni dovol imen");
                }
                if (ime[0] == 'Z')
                {
                    throw new TajniAgentException(ime);
                }
                Console.WriteLine("Pokliči " + ime);
            }
            catch (TajniAgentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

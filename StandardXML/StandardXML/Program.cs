using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace StandardXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ustvari datoteko
            //NogometnaLiga n = new NogometnaLiga();
            ////tukaj je poljubna obdelava podatkov
            //FileStream fs = new FileStream("liga.xml", FileMode.Create);
            //XmlSerializer xml = new XmlSerializer(typeof(NogometnaLiga));
            //xml.Serialize(fs, n);
            //fs.Close();

            //branje iz datoteke
            //NogometnaLiga n = null;
            //FileStream fs = new FileStream("liga.xml", FileMode.Open);
            //XmlSerializer xml = new XmlSerializer(typeof(NogometnaLiga));
            //n = (NogometnaLiga)xml.Deserialize(fs);
            //foreach (Ekipa ekipa in n.liga)
            //{
            //    Console.WriteLine(ekipa.ime);
            //}

            //FileStream fs = new FileStream("Vreme.xml", FileMode.Open);
            //XmlSerializer xml = new XmlSerializer(typeof(data));
            //data m = (data)xml.Deserialize(fs);
            //foreach (dataMetData i in m.metData)
            //{
            //    Console.WriteLine(i.td + " " + i.rhn + " " + i.valid.ToString());
            //}
            //Console.ReadLine();

            //ne naredt xml datoteke iz txt datoteke ker je xml posebna stvar for some fucking reason jebenti fake html
            FileStream fs = new FileStream("data.xml", FileMode.Open);
            XmlSerializer s = new XmlSerializer(typeof(IzdaniRacunEnostavni));
            IzdaniRacunEnostavni a = (IzdaniRacunEnostavni)s.Deserialize(fs);
            foreach (var x in a.Racun.PostavkeRacuna)
                Console.WriteLine(x.OpisiArtiklov.OpisArtikla.OpisArtikla1 + " "+x.KolicinaArtikla.Kolicina+" "+x.ZneskiPostavke.ZnesekPostavke);
               
            Console.ReadLine();
        }
    }
}

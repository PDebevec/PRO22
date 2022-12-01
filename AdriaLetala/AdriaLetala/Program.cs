using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaLetala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdriaLINQDataContext dc = new AdriaLINQDataContext();
            //1. izpiši vsa imena in kode modelov letal iz tabele model
            var letala = from a in dc.MODELs select new { Ime = a.MOD_IME, koda = a.MOD_KODA };
            foreach (var y in letala)
            {
                Console.WriteLine(y.Ime + "\t" + y.koda);
            }
            Console.WriteLine();
            //2. izpiši imena vseh zaposlenih, ki so piloti
            var piloti = from a in dc.PILOTs select new { ime = a.ZAPOSELNI.ZAP_IME, priimek = a.ZAPOSELNI.ZAP_PRIIMEK};
            foreach (var i in piloti)
            {
                Console.WriteLine(i.ime+"\t"+i.priimek);
            }
            Console.WriteLine();
            //3. izpiši imena in priimke vseh strank
            var stranke = from a in dc.STRANKAs select new { ime = a.STR_IME, priimek = a.STR_PRIIMEK };
            foreach (var i in stranke)
            {
                Console.WriteLine(i.ime+"\t"+i.priimek);
            }
            Console.WriteLine();
            //4. izpiši podatke o čarterskih poletih - datum in cilj zbrane po strankah
            var poletistranke = from a in dc.CHARTERs
                         group a by a.STR_KODA into p
                         select p;
            foreach (var i in poletistranke)
            {
                foreach (var j in i)
                {
                    Console.WriteLine(j.CHAR_DATUM+"\t"+j.CHAR_CILJ);
                }
            }
            Console.WriteLine();
            //5. izpiši podatke o čarterskih poletih - datum in cilj, zbrane po pilotih
            var poletipiloti = from a in dc.CHARTERs
                         group a by a.CHAR_PILOT into p
                         select p;
            foreach (var i in poletipiloti)
            {
                foreach (var j in i)
                {
                    Console.WriteLine(j.CHAR_DATUM + "\t" + j.CHAR_CILJ);
                }
            }
            Console.WriteLine();
            //6. izpiši podatke o čarterskih poletih urejene po ciljih
            var poletipocilji = from a in dc.CHARTERs
                               orderby a.CHAR_CILJ
                               select a;
            foreach (var i in poletipocilji)
            {
                Console.WriteLine(i.CHAR_DATUM+"\t"+i.CHAR_CILJ);
            }
            Console.WriteLine();
            //7. razvrsti čarterske polete po urah čakanja- izpiši cilj in ure čakanja
            var poletipočaknju = from a in dc.CHARTERs
                                orderby a.CHAR_UR_ČAKANJA
                                select a;
            foreach (var i in poletipocilji)
            {
                Console.WriteLine(i.CHAR_CILJ + "\t" + i.CHAR_UR_ČAKANJA);
            }
            Console.WriteLine();
            //8. vstavi stranko s priimkom Saksida, imenom Miran v tabelo Strank
            //upoštevaj, da je koda stranke samoštevilo
            STRANKA objs = new STRANKA();
            objs.STR_IME = "Miran";
            objs.STR_PRIIMEK = "Saksida";
            dc.STRANKAs.InsertOnSubmit(objs);
            dc.SubmitChanges();
            //9. stranki s priimkom Ramas spremeni telefon v 123-456
            STRANKA stranka = dc.STRANKAs.Single(s => s.STR_PRIIMEK == "Ramas");
            stranka.STR_TELEFON = "123-456";
            dc.SubmitChanges();
            //10. izbriši stranke s priimkom Smith
            STRANKA delstranka = dc.STRANKAs.FirstOrDefault(s => s.STR_PRIIMEK == "Smith");
            dc.STRANKAs.DeleteOnSubmit(delstranka);
            dc.SubmitChanges();
            Console.ReadLine();
        }
    }
}

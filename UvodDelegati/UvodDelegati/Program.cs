using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodDelegati
{
    internal class Program
    {
        public delegate bool funkcijaZaNize(string s);
        static void Main(string[] args)
        {
            string[] imena = { "Adam", "Alan", "Bob", "Seven", "Jim", "Aiden", "Rob", "bill", "Jacob", "James" };
            
            Console.ReadLine();
        }
        public static List<string> DelajOperacijeNaNizi(string[] mojinizi, funkcijaZaNize mojafunkcija)
        {
            List<string> nova = new List<string>();
            foreach (var i in mojinizi)
            {
                if (mojafunkcija(i))
                    nova.Add(i);
            }
            return nova;
        }
    }
}

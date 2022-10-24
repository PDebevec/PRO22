using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sklad a = new sklad();
            a.push(1);
            a.push("dva");
            skladGen<string> b = new skladGen<string>();
            b.push("ena");
            b.push("2");
            skladGen<double> c = new skladGen<double>();
            c.push(1);
            c.push(Math.PI);
            Console.ReadLine();
        }
    }
}

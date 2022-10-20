﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrika a = new Matrika();
            Matrika b = new Matrika();
            a[0, 0] = 1;
            a[0, 1] = 1;
            a[0, 2] = 0;
            a[1, 0] = 1;
            a[1, 1] = 2;
            a[1, 2] = 1;
            a[2, 0] = 0;
            a[2, 1] = 1;
            a[2, 2] = 0;
            
            b[0, 0] = 1;
            b[0, 1] = 1;
            b[0, 2] = 1;
            b[1, 0] = 2;
            b[1, 1] = 2;
            b[1, 2] = 2;
            b[2, 0] = 0;
            b[2, 1] = 1;
            b[2, 2] = 0;

            a.izpis();
            Console.WriteLine();
            b.izpis();
            Console.WriteLine();
            (a * b).izpis();
            Console.WriteLine();
            (a + b).izpis();
            Console.WriteLine();
            (a - b).izpis();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksnaŠT
{
    internal class Kompleksno
    {
        double re;
        double im;

        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }
        public Kompleksno() { }
        public Kompleksno(double a, double b)
        {
            re = a;
            im = b;
        }

        
    }
}

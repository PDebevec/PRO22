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
        
        public Kompleksno() { re = 0; im = 0; }
        public Kompleksno(double a, double b)
        {
            re = a;
            im = b;
        }

        public static Kompleksno operator +(Kompleksno a, Kompleksno b)
            => new Kompleksno(a.re + b.re, a.im + b.im);
        public static Kompleksno operator -(Kompleksno a, Kompleksno b)
            => new Kompleksno(a.re - b.re, a.im - b.im);
        public static Kompleksno operator *(Kompleksno a, Kompleksno b)
            => new Kompleksno(a.re * b.re - a.im * b.im, a.re * b.im - a.im * b.re);

        public override string ToString()
        {
            if (im == 0)
            {
                if (re == 0)
                    return "0";
                return Convert.ToString(re);
            }
            else if (re == 0)
                return Convert.ToString(re);

            return re + "+" + im + "i";
        }
    }
}

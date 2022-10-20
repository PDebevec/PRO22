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
        
        //public Kompleksno() { re = 0; im = 0; } //idk za manj kode sam ne vem 
        public Kompleksno(double a = 0, double b = 0)
        {
            re = a;
            im = b;
        }

        public static Kompleksno operator +(Kompleksno a, Kompleksno b)
            => new Kompleksno(a.re + b.re, a.im + b.im);
        public static Kompleksno operator -(Kompleksno a, Kompleksno b)
            => new Kompleksno(a.re - b.re, a.im - b.im);
        public static Kompleksno operator *(Kompleksno a, Kompleksno b)
            => new Kompleksno(a.re * b.re - a.im * b.im, a.re * b.im + a.im * b.re);

        public override string ToString()
        {
            if (im == 0)
            {
                if (re == 0)
                    return "0";
                return Convert.ToString(re);
            }
            else if (re == 0)
                return Convert.ToString(im) + "i";

            return re + (im < 0 ? "" : "+") + (Math.Abs(im) == 1 ? "" : Convert.ToString(im)) + "i";
        }
    }
}

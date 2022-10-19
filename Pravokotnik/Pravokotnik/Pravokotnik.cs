using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pravokotnik
{
    internal class Pravokotnik
    {
        public Pravokotnik() { višina = 0; širina = 0; }
        public Pravokotnik(double a, double b)
        {
            višina = a;
            širina = b;
        }
        
        private double višina;
        private double širina;
        public double Višina { get => višina; set => višina = value; }
        public double Širina { get => širina; set => širina = value; }
        
        private static double Površina(double a, double b)
            => a * b;
        public static bool operator >(Pravokotnik a, Pravokotnik b)
            => Površina(a.višina, a.širina) > Površina(b.višina, b.širina);
        public static bool operator <(Pravokotnik a, Pravokotnik b)
            => Površina(a.višina, a.širina) < Površina(b.višina, b.širina);
        public static bool operator >=(Pravokotnik a, Pravokotnik b)
            => Površina(a.višina, a.širina) >= Površina(b.višina, b.širina);
        public static bool operator <=(Pravokotnik a, Pravokotnik b)
            => Površina(a.višina, a.širina) <= Površina(b.višina, b.širina);
        public static bool operator ==(Pravokotnik a, Pravokotnik b)
            => a.višina == b.višina && a.širina == b.širina;
        public static bool operator !=(Pravokotnik a, Pravokotnik b)
            => a.višina != b.višina && a.širina != b.širina;
        
        public override string ToString()
            => "Višina = " + višina + "\t" + "Širina " + širina;
    }
}

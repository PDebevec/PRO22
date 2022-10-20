using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukture
{
    internal class Program
    {
        struct Vektor
        {
            public double x, y, z;
            public double this[int i]
            {
                set {
                    switch (i)
                    {
                        case 0: x = value;break;
                        case 1: y = value;break;
                        case 2: z = value;break;
                        default: throw new IndexOutOfRangeException();
                    }
                }
                get {
                    switch (i)
                    {
                        case 0: return x;
                        case 1: return y;
                        case 2: return z;
                        default: throw new IndexOutOfRangeException("predelač smo šli");
                    }
                }
            }
            public override string ToString()
                => "(" + x + "," + y + "," + z + ")";
            
            //ne moremo itemti kostruktorja brez parametrov
            public Vektor(double x1, double y1, double z1)
            {
                x = x1;y = y1;z = z1;
            }
            public Vektor(Vektor v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
            public static Vektor operator+ (Vektor v1, Vektor v2)
            {
                return new Vektor(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
            }
            //taku je lepše
            public static Vektor operator* (double a, Vektor v)
                => new Vektor(v.x * a, v.y * a, v.z * 5);
            public static Vektor operator* (Vektor v, double a)
                => a * v;
            public static double operator* (Vektor a, Vektor b)
                => a.x * b.x + a.y * b.y + a.z * b.z;
            public static bool operator ==(Vektor a, Vektor b)
                => a.x == b.x && a.y == b.y && a.z == b.z;
            public static bool operator !=(Vektor a, Vektor b)
                => a.x != b.x && a.y != b.y && a.z != b.z;
        }
        static void Main(string[] args)
        {
            Vektor v;
            v.x = 1;
            v.y = -1;
            v.z = 0;
            Vektor a = new Vektor(2, 2, 3);

            Console.WriteLine(v.ToString());
            Console.WriteLine(a.ToString());
            Vektor c = 5 * v + a;
            Console.WriteLine(c.ToString());
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine(v[k]);
            }
            Console.ReadLine();
        }
    }
}

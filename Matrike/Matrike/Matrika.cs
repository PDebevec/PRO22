using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrike
{
    internal class Matrika
    {
        double[,] m = new double[3, 3];
        public double this[int x, int y]
        {
            get { return m[x, y]; }
            set { m[x, y] = value; }
        }
        public Matrika(int a = int.MaxValue) {
            if (a == int.MaxValue) return;
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    m[i, j] = r.Next(0,3);
            }
        }

        public static Matrika operator *(Matrika a, Matrika b)
        {
            Matrika temp = new Matrika();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp[i, j] = 0d;
                    for (int k = 0; k < 3; k++)
                    {
                        temp[i, j] += a[i,k] * b[k,j];
                    }
                }
            }
            return temp;
        }

        public static Matrika operator +(Matrika a, Matrika b)
        {
            Matrika temp = new Matrika();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp[i, j] = a[i,j] + b[i,j];
                }
            }
            return temp;
        }

        public void izpis()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

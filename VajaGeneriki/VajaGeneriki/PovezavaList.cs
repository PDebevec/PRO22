using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaGeneriki
{
    internal class PovezavaList<K,T> where K:IComparable
    {
        Vozel<K, T> glava;
        public PovezavaList()
        {
            glava = new Vozel<K, T>();
        }
        public void Dodaj(K k, T t)
        {
            Vozel<K, T> nov = new Vozel<K, T>(k, t, glava.naslednji);
            glava.naslednji = nov;
        }
        public T Najdi(K k)
        {
            Vozel<K, T> trenutni = glava;
            while(trenutni.naslednji != null)
            {
                if (trenutni.ključ.CompareTo(k)==0)
                    break;
                else
                    trenutni = trenutni.naslednji;
            }
            return trenutni.vsebina;
        }
    }
}

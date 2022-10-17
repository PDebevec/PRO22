using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zankevaja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vaja 1
            //int min = int.MaxValue;
            //for(int k=0; k <= 10; k++)
            //{
            //    Console.WriteLine("vnesi stevilo");
            //    int a = int.Parse(Console.ReadLine());
            //    if (a < min)
            //    {
            //        min = a; 
            //    }
            //}
            //Console.WriteLine("najmanjsi med vnesenimi je "+min);
            //Console.ReadLine();

            //vaja2
            //int vsota = 0;
            //Random r = new Random();
            //for(int k=0; k < 100; k++)
            //{
            //    int st = r.Next(99);
            //    Console.WriteLine("imislil sem si: "+st);
            //    vsota = st + vsota;
            //}
            //Console.WriteLine("vosta je "+vsota);
            //Console.ReadLine();

            //VAJA 3
            //int vsota = 0;
            //Random r = new Random();
            //for (int k = 0; k < 1000; k++)
            //{
            //   int st = r.Next(999);
            //   Console.WriteLine("imislil sem si: "+st);
            //   vsota =  st+vsota;
            //}
            //Console.WriteLine("povprečna vrednost je"+vsota/1000 );
            //Console.ReadLine();


            //VAJA4
            //Random r = new Random();
            //decimal vsota = 0;
            //decimal vsotaobrest = 0;
            //for (int k = 0; k < 100000; k++)
            //{
            //    decimal st = r.Next(1000000);
            //    vsota = vsota + st;
            //    decimal obrest = st*0.023m;
            //    vsotaobrest = vsotaobrest + obrest;



            //}
            //Console.WriteLine("vsota zneskov *2,3%={0,15:f2}",vsota*0.023m);
            //Console.WriteLine("vsota obresti      ={0,15:f2}", vsotaobrest);

            //Console.ReadLine();

            //VAJA5
            Random r = new Random();
            //int k = 0;
            //int vsota = 0;
            //while(k < 10)
            //{
            //    int c = r.Next(1, 11);
            //    vsota = vsota + c;
            //    k++;
            //}
            //Console.WriteLine("vsota je "+vsota);

            //iztacunaj vsoto stevil, ki bojo vnesene
            //zadnje stevilo bo -1 kar pomeni da se program konča
            //ga ne prištejemo v vsoto
            //Console.WriteLine("vnesi stevilo -1 za konec");
            //int a = int.Parse(Console.ReadLine());
            //int vsota = 0;
            //while (a != -1)
            //{
            //    vsota = vsota + a;
            //    Console.WriteLine("vnesi stevilo -1 za konec");
            //    a = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("vsota je :"+vsota);

            //
            Console.WriteLine("zelis da ti izracunam minimum vnesenih stevil? da/ne");
            string odg = Console.ReadLine();//da ali ne
            int min = int.MaxValue;
            while (odg.ToLower() == "da")
            {
                Console.WriteLine("vnesi stevilo");
                int a = int.Parse(Console.ReadLine());
                if (a < min)
                    min = a;
                Console.WriteLine("se kej mona?");
                odg = Console.ReadLine();

            }
            Console.WriteLine("najmanjse je "+ min);
            Console.ReadLine();
        }
    }
}

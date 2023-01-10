using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prioriteta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new PriorityQueue<string>();
            queue.Priority = 1;
            queue.Enqueue("item1");
            queue.Enqueue("item2");
            queue.Priority = 2;
            queue.Enqueue("item3");
            // queue vsebuje sedaj elemente:
            // item3 (priority 2)
            // item1 (priority 1)
            // item2 (priority 1)
            var r = queue.Dequeue(); // vrne "item3"
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}

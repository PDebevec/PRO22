using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace prioriteta
{
    internal class PriorityQueue<T>
    {
        List<QueueItem<string>> queueItems= new List<QueueItem<string>>();

        public int Priority { get; internal set; }

        internal object Dequeue()
        {
            QueueItem<string> item;
            item = queueItems.LastOrDefault();
            queueItems.Remove(item);
            return item.Value;
        }

        internal void Enqueue(string v)
        {
            queueItems.Add(new QueueItem<string>(v, this.Priority));
        }
    }
}
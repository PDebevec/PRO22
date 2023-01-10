using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prioriteta
{
    public class QueueItem<T> : IComparable<QueueItem<T>>
    {
        public QueueItem(T value, int priority)
        {
            Value = value;
            Priority = priority;
        }
        public T Value { get; }
        public int Priority { get; }
        public int CompareTo(QueueItem<T> other)
        {
            if(this.Priority > other.Priority)
                return -1;
            if (other.Priority > this.Priority)
                return 1;
            return 0;
        }
    }

}

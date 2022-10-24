using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class skladGen<T>
    {
        int m_size;
        int m_stackPointer = 0;
        T[] m_item;
        public skladGen(int velikost)
        {
            m_size = velikost;
            m_item = new T[velikost];
        }
        public skladGen() : this(100) { }
        public void push(T item)
        {
            if (m_stackPointer >= m_size)
            {
                throw new Exception("sklad je poven");
            }
            m_item[m_stackPointer] = item;
            m_stackPointer++;
        }
        public T pop()
        {
            m_stackPointer--;
            if (m_stackPointer >= 0)
            {
                return m_item[m_stackPointer];
            }
            m_stackPointer = 0;
            throw new Exception("sklad je prazen");
        }
    }
}

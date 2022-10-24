using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class sklad
    {
        int m_size;
        int m_stackPointer = 0;
        object[] m_item;
        public sklad(int velikost)
        {
            m_size = velikost;
            m_item = new object[velikost];
        }
        public sklad() : this(100) { }
        public void push(object item)
        {
            if (m_stackPointer >= m_size)
            {
                throw new Exception("sklad je poven");
            }
            m_item[m_stackPointer] = item;
            m_stackPointer++;
        }
        public object pop()
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

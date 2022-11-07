using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeljenjeZ0
{
    internal class NegativnoException : Exception
    {
        public NegativnoException(string msg) : base(msg) { }
    }
}

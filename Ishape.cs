using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacees
{
    internal interface Ishape
    {
        public abstract double calculateArea();
        int CompareTo(Square? other);
    }
}

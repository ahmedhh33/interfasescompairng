using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacees
{
    internal class Square : Ishape 
    {
        double Lenght;
        public Square(double lenght)
        {
            this.Lenght = lenght;
        }

        public double calculateArea()
        {
            return this.Lenght*this.Lenght;
        }

        public int CompareTo(Square? other)
        {

            // return this.Lenght>other.Lenght ? 1 : this.Lenght<other.Lenght?-1 : 0;

            if (other == null) { return 1; }//other ways to compare
            if (this.Lenght > other.Lenght)
            { return 1; }

            else if (this.Lenght < other.Lenght)
            {
                return -1;
            }
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_07.Objects
{
    class Square : Objekt2D
    {
        private double a;

        public Square(double a)
        {
            this.a = a;
        }

        public override double Surface() => (a*a);
        public override string ToString()
        {
            return "Square: a = " + a + " S = " + Math.Round(Surface(), 2);
        }
    }
}

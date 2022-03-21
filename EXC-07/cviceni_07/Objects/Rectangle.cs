using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_07.Objects
{
    class Rectangle : Objekt2D
    {
        private double a, b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Surface() => (a * b);
        public override string ToString()
        {
            return "Rectangle: a = " + a + " b = " + b + " S = " + Math.Round(Surface(), 2);
        }
    }
}

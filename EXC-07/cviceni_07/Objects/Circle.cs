using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_07.Objects
{
    class Circle : Objekt2D
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }

        public override double Surface() => (2*Math.PI*r);
        public override string ToString()
        {
            return "Circle: r = " + r + " S = " + Math.Round(Surface(), 2);
        }
    }
}

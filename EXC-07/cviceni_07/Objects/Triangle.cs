using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_07.Objects
{
    class Triangle : Objekt2D
    {
        private double a, va;

        public Triangle(double a, double va)
        {
            this.a = a;
            this.va = va;
        }

        public override double Surface() => (a * va)/2;
        public override string ToString()
        {
            return "Triangle: a = " + a + " va = " + va + " S = " + Math.Round(Surface(), 2);
        }
    }
}

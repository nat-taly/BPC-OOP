using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_07.Objects
{
    class Elipse : Objekt2D
    {
        private double a, b;

        public Elipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Surface() => a * b * Math.PI;
        public override string ToString()
        {
            return "Elipse: a = " + a + " b = " + b + " S = " + Math.Round(Surface(), 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni06
{
    class Rectangle : Objekt2D
    {
        private double a, b;


        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double CountFlat() => (a * b);
        public override String Draw()
        {
            return String.Format("Rectangle:\ta = {0:F2}  b = {1:F2}\t\tS = {2:F2}", a, b, CountFlat());
        }
    }
}

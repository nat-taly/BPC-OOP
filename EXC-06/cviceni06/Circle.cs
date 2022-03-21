using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni06
{
    class Circle : Objekt2D
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CountFlat() => (radius*radius)*Math.PI;
        public override String Draw()
        {
            return String.Format("Circle:\t\tradius = {0:F2}\t\t\tS = {1:F2}", radius, CountFlat());
        }
    }
}

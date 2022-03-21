using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni06
{
    class Triangle : Objekt2D
    {
        private double height_on_side, side;


        public Triangle(double height_on_side, double side)
        {
            this.height_on_side= height_on_side;
            this.side = side;
        }

        public override double CountFlat() => (height_on_side * side)/2;
        public override String Draw()
        {
            return String.Format("Triangle:\tside = {0:F2}  height = {1:F2}\tS = {2:F2}", side, height_on_side, CountFlat());
        }
    }
}

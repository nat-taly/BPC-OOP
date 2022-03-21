using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni06
{
    class Elipse : Objekt2D
    {
        private double main_halfaxis, side_halfaxis;

        public Elipse(double main_halfaxis, double side_halfaxis)
        {
            this.main_halfaxis = main_halfaxis;
            this.side_halfaxis = side_halfaxis;
        }

        public override double CountFlat() => main_halfaxis * side_halfaxis * Math.PI;
        public override String Draw()
        {
            return String.Format("Elipse:\t\tmain-ax = {0:F2}  side-ax = {1:F2}\tS = {2:F2}", main_halfaxis, side_halfaxis, CountFlat());
        }
    }
}

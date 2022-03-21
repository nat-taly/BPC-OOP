using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_07.Objects
{
    class Elipse : Objekt2D
    {
        private double main_halfaxis, side_halfaxis;

        public Elipse(double main_halfaxis, double side_halfaxis)
        {
            this.main_halfaxis = main_halfaxis;
            this.side_halfaxis = side_halfaxis;
        }

        public override double Surface() => main_halfaxis * side_halfaxis * Math.PI;
        public override string ToString()
        {
            return "Elipse: a = " + main_halfaxis + " b = " + side_halfaxis + " S = " + Math.Round(Surface(), 2);
        }
    }
}

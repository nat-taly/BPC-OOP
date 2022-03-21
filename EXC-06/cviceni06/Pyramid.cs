using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni06
{
    //pravidelny jehlan!!
    class Pyramid : Objekt3D
    {
        private double a = 0, v = 0;

        public Pyramid( double lenght_of_side, double height)
        {
            this.a = lenght_of_side;
            this.v = height;
        }

        //GETTER and SETTER

        public override double CountSurface() => Math.Pow(a, 2) + 4 * 0.5 * a * v;

        public override double CountVolume() => 0.33 * a * a * v;


        public override String Draw()
        {
            return String.Format("Pyramid:\tside = {0:F2}  height = {1:F2}\tS = {2:F2}  V = {3:F2}", a, v, CountSurface(), CountVolume());
        }
    }
}

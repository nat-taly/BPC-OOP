using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni06
{
    class Cuboid : Objekt3D
    {
        private double a, b, c;


        public Cuboid(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CountSurface() => 2*((a*b)+(b*c)+(c*a));
        public override double CountVolume() => (a * b * c);
    

        public override String Draw()
        {
            return String.Format("Cuboid:\t\ta = {0:F2}  b = {1:F2}  c = {2:F2}\tS = {3:F2}  V = {4:F2}", a, b, c, CountSurface(), CountVolume());
        }
    }
}

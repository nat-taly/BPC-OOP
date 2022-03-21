using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni06
{
    class Sphere : Objekt3D
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double CountSurface() => 4*Math.PI*radius*radius;
        public override double CountVolume() => (4*Math.PI*radius*radius*radius)/3;


        public override String Draw()
        {
            return String.Format("Sherpe:  \tradius = {0:F2}\t\t\tS = {1:F2}  V = {2:F2}", radius, CountSurface(), CountVolume());
        }
    }
}

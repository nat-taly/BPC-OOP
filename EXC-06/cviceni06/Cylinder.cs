using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni06
{
    class Cylinder : Objekt3D
    {
        private double radius, height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double CountSurface() => 2*Math.PI*radius*(radius+height);
        public override double CountVolume() => (Math.PI*radius*radius*height);


        public override String Draw()
        {
            return String.Format("Cylinder:\tradius = {0:F2}  height = {1:F2}\tS = {2:F2}  V = {3:F2}", radius, height, CountSurface(), CountVolume());
        }
    }
}

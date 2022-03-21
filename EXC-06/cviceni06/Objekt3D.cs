using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni06
{
    abstract class Objekt3D : GrObjekt
    {
        public abstract double CountSurface();
        public abstract double CountVolume();
    }
}

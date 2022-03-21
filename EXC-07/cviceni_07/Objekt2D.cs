using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_07
{
    public abstract class Objekt2D : I2D, IComparable
    {
        public abstract double Surface();
        public int CompareTo(object obj)
        {
            Objekt2D otherSurface = ((Objekt2D)obj);
            if(otherSurface.Surface() < Surface())
            {
                return 1;
            }
            if (otherSurface.Surface() > Surface())
            {
                return -1;
            }
            else { return 0; }
        }
    }
}

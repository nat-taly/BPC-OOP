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
            
            if (obj == null) { 
                return 1; 
            }
            Objekt2D otherSurface = obj as Objekt2D;
            if (otherSurface != null)
            {
                return this.Surface().CompareTo(otherSurface.Surface());
            }
     
            else {
                throw new ArgumentException("not possible to compare");
            }
            
   
            
        }
    }
}

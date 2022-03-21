using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_07
{
    class Exterms
    {
        public static T Smallest<T>(T[] pole) where T : IComparable
        {
            T min;
            try
            {
                min = pole[0];
            } 
            catch (NullReferenceException e)
            {
                throw new SystemException("Empty");
            }
            for(int i=0; i< pole.Length; i++)
            {
                if (min.CompareTo(pole[i]) > 0)
                {
                    min = pole[i];
                }
            }
            return min;

        }
        public static T Biggest<T>(T[] pole) where T : IComparable
        {
            T max;
            try
            {
                max = pole[0];
            }
            catch (NullReferenceException e)
            {
                throw new SystemException("Empty");
            }
            for (int i = 0; i < pole.Length; i++)
            {
                if (max.CompareTo(pole[i]) < 0)
                {
                    max = pole[i];
                }
            }
            return max;

        }
    }
}

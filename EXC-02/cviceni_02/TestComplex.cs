using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_02
{
    class TestComplex
    {
        public static void Test(ComplexNumber actual, ComplexNumber expect, string operace)
        {
            const double epsilon = 1 * 10 ^ -6;

            Console.WriteLine("Test Name: " + operace);
           
            if (((actual.Imag - expect.Imag) < epsilon) && ((actual.Real - expect.Real) < epsilon))
            {
                Console.WriteLine("OK");
            } else
            {
                Console.WriteLine("Error: Num: " + actual + " Expect Num: " + expect); 
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_02
{

    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber a = new ComplexNumber(12, 8);
            ComplexNumber b = new ComplexNumber(2, 8);

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(ComplexNumber.Unar(a));

            Console.WriteLine("\n");

            Console.WriteLine(ComplexNumber.Modul(a));
            Console.WriteLine(ComplexNumber.AssociatedNumber(a));
            Console.WriteLine(ComplexNumber.Argument(a));

            Console.WriteLine("\n");

            TestComplex.Test(a, b, "+");

            Console.ReadLine();
        }
    }
}

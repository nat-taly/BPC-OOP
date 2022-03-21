using cviceni_07.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 1, 3, 4, 7, 9 };

            Circle[] cirles = { 
                new Circle(2),
                new Circle(5) 
            };

            Square[] squares = { 
                new Square(2.0), 
                new Square(18.0), 
                new Square(5.0) 
            };

            Elipse[] elipses = {
                new Elipse(2.0, 4.0),
                new Elipse(10.0, 2.0), 
                new Elipse (1.0, 5.0)
            };

            Rectangle[] rectangles = { 
                new Rectangle(1.0, 4.0), 
                new Rectangle(8.0, 2.0), 
                new Rectangle(2.0, 5.0) 
            };

            Triangle[] triangles = {
                new Triangle(11.0, 4.0), 
                new Triangle(16.0, 6.0),
                new Triangle(10.0, 1.0) 
            };

            Objekt2D[] objekt2Ds = {
                new Circle(2.0), 
                new Square(10.0), 
                new Elipse(1.0, 5.0), 
                new Rectangle(8.0, 2.0),
                new Triangle(20.0, 6.0)
            };
       
        
            Console.WriteLine("BIGGEST  int: {0}", Exterms.Biggest(arrayInt));
            Console.WriteLine("SMALLEST int: {0}", Exterms.Smallest(arrayInt));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  int: {0}", Exterms.Biggest(cirles));
            Console.WriteLine("SMALLEST int: {0}", Exterms.Smallest(cirles));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  int: {0}", Exterms.Biggest(squares));
            Console.WriteLine("SMALLEST int: {0}", Exterms.Smallest(squares));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  int: {0}", Exterms.Biggest(elipses));
            Console.WriteLine("SMALLEST int: {0}", Exterms.Smallest(elipses));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  int: {0}", Exterms.Biggest(rectangles));
            Console.WriteLine("SMALLEST int: {0}", Exterms.Smallest(rectangles));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  int: {0}", Exterms.Biggest(triangles));
            Console.WriteLine("SMALLEST int: {0}", Exterms.Smallest(triangles));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  int: {0}", Exterms.Biggest(objekt2Ds));
            Console.WriteLine("SMALLEST int: {0}", Exterms.Smallest(objekt2Ds));
            Console.WriteLine();


            int[] arrayInt2 = { 1, 3, 5, 7, 9 };
            List<int> intList = new List<int>(new int[] { 1, 3, 5, 7, 9 });
            var res = from p in intList where (p > 4 && p < 8) select p;
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

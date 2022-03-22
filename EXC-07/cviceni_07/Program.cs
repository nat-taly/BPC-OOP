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

            string[] arrayStr = {
                "AH1",
                "AH2",
                "AH4"
            };

            Circle[] cirles = {
                new Circle(2),
                new Circle(5)
            };

            Square[] squares = {
                new Square(2),
                new Square(18),
                new Square(5)
            };

            Elipse[] elipses = {
                new Elipse(2, 3),
                new Elipse(10, 8),
                new Elipse (1, 5)
            };

            Rectangle[] rectangles = {
                new Rectangle(1, 4),
                new Rectangle(8, 2),
                new Rectangle(2, 50)
            };

            Triangle[] triangles = {
                new Triangle(6, 4),
                new Triangle(16, 6),
                new Triangle(10, 8)
            };

            Objekt2D[] objekt2Ds = {
                new Circle(2),
                new Square(10),
                new Elipse(4, 5),
                new Rectangle(8, 2),
                new Triangle(14, 6)
            };

            Console.WriteLine("BIGGEST  : {0}", Exterms.Biggest(arrayInt));
            Console.WriteLine("SMALLEST : {0}", Exterms.Smallest(arrayInt));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  : {0}", Exterms.Biggest(arrayStr));
            Console.WriteLine("SMALLEST : {0}", Exterms.Smallest(arrayStr));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  : {0}", Exterms.Biggest(cirles));
            Console.WriteLine("SMALLEST : {0}", Exterms.Smallest(cirles));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  : {0}", Exterms.Biggest(squares));
            Console.WriteLine("SMALLEST : {0}", Exterms.Smallest(squares));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  : {0}", Exterms.Biggest(elipses));
            Console.WriteLine("SMALLEST : {0}", Exterms.Smallest(elipses));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  : {0}", Exterms.Biggest(rectangles));
            Console.WriteLine("SMALLEST : {0}", Exterms.Smallest(rectangles));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  : {0}", Exterms.Biggest(triangles));
            Console.WriteLine("SMALLEST : {0}", Exterms.Smallest(triangles));
            Console.WriteLine();

            Console.WriteLine("BIGGEST  : {0}", Exterms.Biggest(objekt2Ds));
            Console.WriteLine("SMALLEST : {0}", Exterms.Smallest(objekt2Ds));
            Console.WriteLine();

            
            Console.WriteLine(rectangles[0].CompareTo(null));
            Console.WriteLine(rectangles[0].CompareTo(arrayStr[1]));

            int[] array = { 1, 3, 5, 7, 9 };
            IEnumerable<int> scoreQuery = from score in array where (score > 4 && score < 8) select score;
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}

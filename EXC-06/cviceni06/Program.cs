using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni06
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum_volume = 0, sum_surface = 0, sum_flat = 0;
            GrObjekt[] objects =
            {
                new Circle(10),
                new Rectangle(10,7),
                new Elipse(2, 7),
                new Triangle(2, 7),
                new Cuboid(2, 2, 2),
                new Cylinder(2, 9),
                new Sphere(2),
                new Pyramid(4,5)
            };

            for(int i=0; i<objects.Length; i++)
            {
                if(objects[i] != null && objects[i] is Objekt2D)
                {
                    sum_flat += ((Objekt2D)objects[i]).CountFlat();
                }
                else if (objects[i] != null)
                {
                    sum_surface += ((Objekt3D)objects[i]).CountSurface();
                    sum_volume += ((Objekt3D)objects[i]).CountVolume();
                }
            }

            for (int i = 0; i < objects.Length; i++)
            {
                Console.WriteLine(objects[i].Draw());
            }

            Console.WriteLine();
            Console.WriteLine(String.Format("Sum flat: {0:F2}  Sum surface: {1:F2}   Sum volume: {2:F2}", sum_flat, sum_surface, sum_volume));
            Console.ReadLine();
        }
    }
}

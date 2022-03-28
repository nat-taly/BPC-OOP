using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_08
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureArchive t = new TemperatureArchive();
            t.Load();
            
            t.PrintTemperatures();
            Console.WriteLine();
            t.PrintAverageTemperature();
            Console.WriteLine();
            t.PrintAverageMonthTemperature();
            Console.WriteLine();
            t.Calibration(0.1);
            Console.WriteLine();
            t.PrintTemperatures();

            t.Save();
            Console.ReadLine();
        }
    }
}

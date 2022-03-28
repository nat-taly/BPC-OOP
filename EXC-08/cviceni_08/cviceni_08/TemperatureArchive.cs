using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_08
{
    class TemperatureArchive
    {
        private SortedDictionary<int, YearTemperature> _archiv;
        public TemperatureArchive()
        {
            this._archiv = new SortedDictionary<int, YearTemperature>();
        }

        public void add(int year, List<double> data)
        {
            this._archiv.Add(year, new YearTemperature(year, data));
        }

        private const string MainDirectory = "C:\\Users\\vycho\\Desktop\\BPC-OOP-Excercses\\EXC-08\\cviceni_08\\cviceni_08";
        private const string InputFile = "input.txt";
        private const string OutputFile = "output.txt";

        public void Load()
        {
            try
            {
                String path = Path.Combine(MainDirectory, InputFile);
                StreamReader reader = File.OpenText(path);
                string line = null;
                this._archiv.Clear();
                int lineNumber = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;
                    char[] separators = new char[] { ' ', ':', ';', '\n'};
                    string[] list = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                
                    int year = Int32.Parse(list[0]);

                    List<double> data = new List<double> { };
                    for (int i = 1; i < list.Length; i++)
                    {
                        data.Add(Convert.ToDouble(list[i]));
                    }
                    if (data.Count != 12)
                    {
                        Console.WriteLine("ERR: incorrect data in line {0}", lineNumber);
                    }
                    else
                    {
                        this._archiv.Add(year, new YearTemperature(year, data));
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public void Save()
        {
            try
            {
                String path = Path.Combine(MainDirectory, OutputFile);
                StreamWriter writer = File.CreateText(path);
                foreach (int item in _archiv.Keys)
                {
                    writer.Write(item);
                    bool first = true;
                    foreach (double one in _archiv[item].Data)
                    {
                        if (first)
                        {
                            writer.Write(": ");
                            first = false;
                        }
                        else
                        {
                            writer.Write("; ");
                        }
                        writer.Write(one);
                    }
                    writer.Write(writer.NewLine);
                }
                writer.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }


        public YearTemperature Search(int year)
        {
            return this._archiv[year];
        }

        public void PrintTemperatures()
        {
            foreach (int one in _archiv.Keys)
            {
                Console.Write("{0,4}:", one);
                foreach (double item in _archiv[one].Data)
                {
                    Console.Write("{0,8:0.0}", item);
                }
                Console.WriteLine("");
            }
        }

        public void PrintAverageTemperature()
        {
            foreach (int item in _archiv.Keys)
            {
                Console.WriteLine("{0,4}: {1,7:0.0}", item, _archiv[item].AverageTemperatre);
            }
        }

        public void PrintAverageMonthTemperature()
        {
            Console.Write("Avr.:");
            double sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum = 0;
                foreach (int item in _archiv.Keys)
                {
                    sum += _archiv[item].Data[i];
                }
                Console.Write("{0,8:0.0}", sum / _archiv.Count);
            }
            Console.WriteLine("");
        }

        public void Calibration(double value)
        {
            foreach (int item in this._archiv.Keys)
            {
                this._archiv[item].Calibration(value);
            }
        }

    }
}


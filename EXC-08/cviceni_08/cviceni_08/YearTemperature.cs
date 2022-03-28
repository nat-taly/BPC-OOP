using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_08
{
    class YearTemperature
    {
        private int year;
        private List<double> data = new List<double>();

        public YearTemperature(int year, List<double> data)
        {
            this.year = year;
            this.data = data;
        }

        public List<double> MonthTemperature
        {
            get { return data; }
            set
            {
                if (value.Count != 12)
                {
                    throw new Exception("Invalid input");
                }
                else
                {
                    data = value;
                }
            }
        }

        public double MaxTemperatre
        {
            get { return data.Max(); }
        }

        public double MinTemperatre
        {
            get { return data.Min(); }
        }

        public double AverageTemperatre
        {
            get
            {
                double sum = 0;
                foreach (double item in data)
                {
                    sum += item;
                }
                return sum / data.Count;
            }
        }

        public void Calibration(double value)
        {
            for (int i = 0; i < data.Count; i++)
            {
                data[i] += value;
            }
        }

        public List<double> Data
        {
            get { return data; }
        }
    }
}


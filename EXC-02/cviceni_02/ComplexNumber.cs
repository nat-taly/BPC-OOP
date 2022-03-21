using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_02
{
    class ComplexNumber
    {
        public double Real;
        public double Imag;

        public ComplexNumber(double real = 0.0, double imag = 0.0)
        {
            Real = real;
            Imag = imag;
        }

        // summary
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imag + b.Imag);
        }

        //diference
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imag - b.Imag);
        }

        //nasobeni
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber((a.Real*b.Real - a.Imag*b.Imag), (a.Real*b.Imag + a.Imag*b.Real));
        }

        //devide
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double r = ((a.Real*b.Real + a.Imag*b.Imag) / (b.Real*b.Real + b.Imag*b.Imag));
            double i = ((a.Imag*b.Real - a.Real*b.Imag) / (b.Real * b.Real + b.Imag * b.Imag));
            return new ComplexNumber(r,i);
        }

        //UNARNI operator 
        public static ComplexNumber operator -(ComplexNumber a)
        {
            return new ComplexNumber(-a.Real , -a.Imag);
        }



        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            return (a.Real == b.Real && a.Imag == b.Imag);
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(a == b);
        }


        // metod ToString
        public override string ToString()
        {
            if (Imag < 0)
            {
                return string.Format("{0}-{1}j", Real, -Imag);
            }
            else
            {
                return string.Format("{0}+{1}j", Real, Imag);
            }
        }

        //metod Complex invers
        public static ComplexNumber AssociatedNumber(ComplexNumber a)
        {
            return new ComplexNumber(a.Real, -a.Imag);
        }

        public static double Modul(ComplexNumber a)
        {
            return Math.Sqrt(a.Real * a.Real + a.Imag * a.Imag);
        }

        public static double Argument(ComplexNumber a)
        {
            return Math.Acos(a.Real/Modul(a));
        }

    }
}

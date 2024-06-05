using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class ComplexNumber
    {
        private double a1;
        private double b1;

        public double A1 { get => a1; set => a1 = value; }
        public double B1 { get => b1; set => b1 = value; }

        public ComplexNumber() { }
        public ComplexNumber(double a1, double b1)
        {
            this.a1 = a1;
            this.b1 = b1;
        }
        public double Moduls()
        {
            return Math.Sqrt(a1 * a1 + b1 * b1);
        }
        public override string ToString()
        {
            return $"{a1} + {b1}i";
        }
        public ComplexNumber Inverse()
        {
            return new ComplexNumber(a1/(a1*a1+b1*b1), -b1/(a1 * a1 + b1 * b1));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class TwoComplexNumbers : ComplexNumber
    {
   
        public double A2 { get; }
        public double B2 { get; }

        public TwoComplexNumbers(double a1, double b1, double a2, double b2):base(a1,b1)
        {
            A2 = a2;
            B2 = b2;
        }
        public ComplexNumber Multiply()
        {
            double resultReal = A1 * A2 - B1 * B2;
            double resultImaginary = A1 * A2 - B1 * B2;
            return new ComplexNumber(resultReal, resultImaginary);
        }
    }
}

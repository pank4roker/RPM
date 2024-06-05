using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите действительную часть комплексного числа (a1): ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа (b1): ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            ComplexNumber complexNumber = new ComplexNumber(a1, b1);
            double modulus = complexNumber.Moduls();
            Console.WriteLine($"Модуль комплексного числа {complexNumber} равен: {modulus}");
            Console.WriteLine($"Обратное комплексное число для {complexNumber} равно: {complexNumber.Inverse()}");

            Console.Write("Введите действительную часть второго комплексного числа (a2): ");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите мнимую часть второго комплексного числа (b2): ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            TwoComplexNumbers complexPair = new TwoComplexNumbers(a1, b1, a2, b2);

            Console.WriteLine($"Произведение комплексных чисел ({a1} + {b1}i) и ({a2} + {b2}i) равно: {complexPair.Multiply()}");
            Console.ReadLine();
        }
    }
}

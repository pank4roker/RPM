using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив для демонстрации
            double[] numbers = { 1.0, 2.0, 3.0, 4.0, 5.0 };

            // Создаем задачу для вычисления среднего арифметического
            Task<double> task = Task.Run(() => CalculateAverage(numbers));

            // Ожидаем завершения задачи и получаем результат
            double average = task.Result;

            // Выводим результат на консоль
            Console.WriteLine($"Среднее арифметическое: {average}");

            // Для того чтобы консоль не закрылась сразу после выполнения программы
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }

        // Метод для вычисления среднего арифметического элементов массива
        static double CalculateAverage(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Массив не может быть пустым");
            }

            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }
    }
}

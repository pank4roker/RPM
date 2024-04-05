using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        delegate Task<int> AsyncMatrixDifference(int rows, int cols);
        static void Main(string[] args)
        {
            // Вызов асинхронного метода и ожидание завершения
            int matrixSize = 5;
            AsyncMatrixDifference asyncMethod = (rows, cols) => Task.Run(() => GetMatrixDifference(rows, cols));
            var resultTask = asyncMethod(matrixSize, matrixSize);
            int result = resultTask.GetAwaiter().GetResult();

            // Вывод результата
            Console.WriteLine($"Разница между максимальным и минимальным элементами матрицы: {result}");
            Console.ReadKey();
        }

        // Метод для вычисления разницы между максимальным и минимальным элементами матрицы
        static int GetMatrixDifference(int rows, int cols)
        {
            var random = new Random();
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Исходная матрица:");
            // Заполнение исходной матрицы случайными числами
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(100); // Заполнение случайными значениями от 0 до 99
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Нахождение максимального и минимального элементов
            int max = int.MinValue;
            int min = int.MaxValue;
           
            foreach (var num in matrix)
            {
                max = Math.Max(max, num);
                min = Math.Min(min, num);
            }
            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Минимальный элемент: {min}");
            // Возвращение разницы между максимальным и минимальным элементами
            return max - min;
        }
    }
}

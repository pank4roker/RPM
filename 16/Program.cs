using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        delegate Task<int> AsyncMatrixDifference(int rows, int cols);

        static async Task Main(string[] args)
        {
            // Вызов асинхронного метода и ожидание завершения с тайм-аутом
            int matrixSize = 5;
            AsyncMatrixDifference asyncMethod = (rows, cols) => GetMatrixDifferenceAsync(rows, cols);
            var resultTask = asyncMethod(matrixSize, matrixSize);

            // Ожидание выполнения задачи с тайм-аутом
            var timeoutTask = Task.Delay(TimeSpan.FromSeconds(5)); // Тайм-аут в 5 секунд
            var completedTask = await Task.WhenAny(resultTask, timeoutTask);

            if (completedTask == timeoutTask)
            {
                Console.WriteLine("Время ожидания истекло. Процесс выполнения прерван.");
                return;
            }

            // Вывод результата
            int result = await resultTask;
            Console.WriteLine($"Разница между максимальным и минимальным элементами матрицы: {result}");
            Console.ReadKey();
        }

        // Асинхронный метод для вычисления разницы между максимальным и минимальным элементами матрицы
        static async Task<int> GetMatrixDifferenceAsync(int rows, int cols)
        {
            var random = new Random();
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Исходная матрица:");

            // Заполнение исходной матрицы случайными числами и вывод информации о ходе выполнения
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(100); // Заполнение случайными значениями от 0 до 99
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
                await Task.Delay(100); // Задержка для имитации работы
                Console.WriteLine($"Обработано строк: {i + 1} из {rows}");
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

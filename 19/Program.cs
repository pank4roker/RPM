using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
      
        // Метод для поиска элемента в матрице
        public static bool SearchElement(double[,] matrix, double target)
        {
            // Получаем количество строк и столбцов матрицы
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            bool found = false;

            // Создание и запуск потока для поиска элемента в матрице
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        if (matrix[i, j] == target)
                        {
                            found = true;
                            return; // Выход из метода при нахождении элемента
                        }
                    }
                }
            });

            thread.Start(); // Запуск потока

            thread.Join(); // Ожидание завершения потока

            return found; // Возвращение результата поиска
        }

        // Основной метод программы
        static void Main(string[] args)
        {
            // Пример матрицы
            double[,] matrix = {
                { 1.1, 2.2, 3.3 },
                { 4.4, 5.5, 6.6 },
                { 7.7, 8.8, 9.9 }
            };
            bool exists = false;

            // Цикл для повторения запроса ввода значения target до тех пор, пока пользователь не решит выйти
            while (true)
            {
                // Запрос ввода значения target
                Console.Write("Введите значение для поиска: ");
                double target;
                while (!double.TryParse(Console.ReadLine(), out target))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                    Console.Write("Введите значение для поиска: ");
                }

                // Вызов метода SearchElement и вывод результата
                exists = SearchElement(matrix, target);
                Console.WriteLine($"Элемент {target} {(exists ? "существует" : "не существует")} в матрице.");

                // Если элемент найден, предложение продолжить поиск
                if (exists)
                {
                    Console.Write("Хотите продолжить поиск? (y/n): ");
                    string continueSearch = Console.ReadLine().Trim().ToLower();
                    if (continueSearch != "y")
                    {
                        Console.WriteLine("Программа завершена.");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

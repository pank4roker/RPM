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
        // Класс для хранения результата поиска
        public class SearchResult
        {
            public bool Found { get; set; }
        }

        // Класс для данных поиска
        public class SearchData
        {
            public double Target { get; set; }
        }

        // Метод для поиска элемента в матрице
        public static bool SearchElement(double[,] matrix, double target)
        {
            // Получаем количество строк и столбцов матрицы
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            // Создаем объект для хранения результатов
            var result = new SearchResult();

            // Создание и запуск потока для поиска элемента в матрице
            Thread thread = new Thread(new ParameterizedThreadStart((obj) =>
            {
                var searchData = (SearchData)obj;
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        if (matrix[i, j] == searchData.Target)
                        {
                            result.Found = true;
                            return; // Выход из метода при нахождении элемента
                        }
                    }
                }
            }));

            thread.Start(new SearchData { Target = target }); // Запуск потока с передачей аргумента

            thread.Join(); // Ожидание завершения потока

            return result.Found; // Возвращение результата поиска
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

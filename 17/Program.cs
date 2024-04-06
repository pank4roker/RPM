using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        // Объявление делегата для обратного вызова
        delegate void StringResultCallback(string result);

        static async Task Main(string[] args)
        {
            // Пример массива строк
            string[] stringArray = { "яблоко", "банан", "виноград", "арбуз" };

            // Вызываем асинхронный метод и ожидаем результат
            await GetStringWithMaxLengthAsync(stringArray, HandleStringResult);

            Console.ReadKey();
        }

        // Асинхронный метод для получения строки максимальной длины из массива строк
        static async Task GetStringWithMaxLengthAsync(string[] stringArray, StringResultCallback callback)
        {
            await Task.Run(() =>
            {
                // Ищем строку максимальной длины
                string maxLengthString = stringArray[0];
                foreach (var str in stringArray)
                {
                    if (str.Length > maxLengthString.Length)
                        maxLengthString = str;
                }

                // Вызываем метод обратного вызова с результатом
                callback(maxLengthString);
            });
        }

        // Метод обратного вызова для обработки результата
        static void HandleStringResult(string result)
        {
            Console.WriteLine($"Строка максимальной длины: {result}");
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
    static void Main()
    {
        string filePath = @"C:\Users\Kirill\Desktop\24\File.txt";  // Путь к файлу

        try
        {
            double sum = 0;  // Переменная для суммы чисел

            // Чтение всех строк файла
            string[] lines = File.ReadAllLines(filePath);

            // Перебор всех строк
            foreach (string line in lines)
            {
                // Разбиение строки на отдельные числа, предполагая, что числа разделены пробелами
                string[] numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // Перевод строковых представлений чисел в double и их суммирование
                foreach (string number in numbers)
                {
                    if (double.TryParse(number, out double num))
                    {
                        sum += num;
                    }
                    else
                    {
                        Console.WriteLine($"Не удалось преобразовать '{number}' в число.");
                    }
                }
            }

            // Вывод суммы
            Console.WriteLine($"Сумма чисел в файле: {sum}");
                Console.ReadKey();
        }
        catch (Exception ex)
        {
            // Обработка ошибок при работе с файлом
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
}

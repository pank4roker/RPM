using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11pr_Rpm_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();

            test.AddQuestion("Вопрос 1: Что такое C#?", new List<string> { "Язык программирования", "Фреймворк", "База данных" }, 0, 10);
            test.AddQuestion("Вопрос 2: Сколько типов данных в C#?", new List<string> { "3", "5", "7" }, 2, 10);
            test.AddQuestion("Вопрос 3: Что такое .NET?", new List<string> { "Операционная система", "Платформа разработки", "Браузер" }, 1, 10);

            for (int i = 0; i < test.questions.Count; i++)
            {
                test.DisplayQuestion(i);
                Console.Write("Введите номер выбранного варианта ответа: ");
                int selectedOption = int.Parse(Console.ReadLine());
                test.ChooseOption(i, selectedOption);
            }

            Console.WriteLine("\nРезультаты тестирования:");
            test.DisplayResults();
            Console.ReadKey();
        }
    }
}

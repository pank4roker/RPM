using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26pr
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите дату (в формате ГГГГ-ММ-ДД): ");
            //string input = Console.ReadLine();

            //if (DateTime.TryParse(input, out DateTime date))
            //{
            //    // Получаем номер дня недели (0 - воскресенье, 1 - понедельник, ..., 6 - суббота)
            //    int dayOfWeek = (int)date.DayOfWeek -1;

            //    // Переводим день недели в формат (1 - понедельник, ..., 7 - воскресенье)
            //    int correctedDayOfWeek = dayOfWeek == 0 ? 7 : dayOfWeek;

            //    Console.WriteLine($"Номер дня недели для {date.ToString("yyyy-MM-dd")} это {correctedDayOfWeek}");
            //}
            //else
            //{
            //    Console.WriteLine("Некорректный формат даты.");
            //}
            Console.Write("Введите дату рождения (в формате ГГГГ-ММ-ДД): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime birthDate))
            {
                DateTime today = DateTime.Today;
                DateTime thisYearBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

                if (thisYearBirthday < today)
                {
                    int daysPassed = (today - thisYearBirthday).Days;
                    Console.WriteLine($"День рождения уже прошёл {daysPassed} дней назад.");
                }
                else if (thisYearBirthday > today)
                {
                    int daysLeft = (thisYearBirthday - today).Days;
                    Console.WriteLine($"До дня рождения осталось {daysLeft} дней.");
                }
                else
                {
                    Console.WriteLine("Сегодня ваш день рождения! Поздравляем!");
                }
            }
            else
            {
                Console.WriteLine("Некорректный формат даты.");
            }
            Console.ReadLine();
        }
    }

}

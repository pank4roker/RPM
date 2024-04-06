using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13pr_RPM_
{
    // Класс, представляющий данные о вакансии
    class JobVacancy
    {
        public string Title { get; set; }     // Название вакансии
        public string Company { get; set; }   // Название компании
        public int Salary { get; set; }       // Зарплата

        // Переопределение метода ToString() для удобного вывода информации о вакансии
        public override string ToString()
        {
            return $"{Title} | {Company} | {Salary}"; // Возвращаем строку с данными о вакансии
        }
    }

    class Program
    {
        // Делегат для определения критерия сортировки
        delegate int SortingCriteria(JobVacancy a, JobVacancy b);

        static void Main(string[] args)
        {
            List<JobVacancy> vacancies = new List<JobVacancy>(); // Создание списка вакансий

            // Считывание данных о вакансиях
            vacancies = ReadVacancies();

            // Проверка, что список вакансий не пустой
            if (vacancies.Count == 0)
            {
                Console.WriteLine("Вы не ввели данные о вакансиях. Программа завершается.");
                return;
            }

            // Сортировка по умолчанию (по зарплате, от большей к меньшей)
            SortingCriteria defaultSortingCriteria = (a, b) => b.Salary.CompareTo(a.Salary);
            vacancies.Sort((a, b) => defaultSortingCriteria(a, b));

            while (true)
            {
                // Выбор критерия сортировки
                Console.WriteLine("\nВыберите критерий сортировки:");
                Console.WriteLine("1. По названию вакансии (по алфавиту)");
                Console.WriteLine("2. По названию компании (по алфавиту)");
                Console.WriteLine("3. По зарплате (от большей к меньшей)");
                Console.WriteLine("4. Выйти из программы");
                Console.Write("Введите номер: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Неверный выбор.");
                    continue;
                }

                if (choice == 4) // Проверка выбора выхода из программы
                    break;

                SortingCriteria sortingCriteria = null;
                switch (choice)
                {
                    case 1: // Сортировка по названию вакансии
                        sortingCriteria = (a, b) => string.Compare(a.Title, b.Title);
                        break;
                    case 2: // Сортировка по названию компании
                        sortingCriteria = (a, b) => string.Compare(a.Company, b.Company);
                        break;
                    case 3: // Сортировка по зарплате (от большей к меньшей)
                        sortingCriteria = (a, b) => b.Salary.CompareTo(a.Salary);
                        break;
                    default:
                        throw new InvalidOperationException("Неверный выбор.");
                }

                // Сортировка и вывод результатов
                vacancies.Sort((a, b) => sortingCriteria(a, b));
                Console.WriteLine("\nОтсортированные данные о вакансиях:");
                foreach (var vacancy in vacancies)
                {
                    Console.WriteLine(vacancy);
                }
            }
        }

        // Метод для считывания данных о вакансиях
        static List<JobVacancy> ReadVacancies()
        {
            List<JobVacancy> vacancies = new List<JobVacancy>(); // Создание списка вакансий

            Console.WriteLine("Введите данные о вакансиях (или введите пустую строку для завершения ввода):");

            while (true)
            {
                Console.Write("Название вакансии: ");
                string title = Console.ReadLine(); // Считывание названия вакансии

                if (string.IsNullOrWhiteSpace(title)) // Проверка на пустую строку для завершения ввода
                    break;

                Console.Write("Название компании: ");
                string company = Console.ReadLine(); // Считывание названия компании

                int salary;
                Console.Write("Зарплата: ");
                while (!int.TryParse(Console.ReadLine(), out salary)) // Проверка на корректный ввод зарплаты
                {
                    Console.WriteLine("Неверный формат зарплаты. Повторите ввод.");
                    Console.Write("Зарплата: ");
                }

                vacancies.Add(new JobVacancy { Title = title, Company = company, Salary = salary }); // Добавление вакансии в список
            }

            return vacancies; // Возвращаем список вакансий
        }
    }
}


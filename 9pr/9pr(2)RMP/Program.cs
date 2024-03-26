using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr_2_RMP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса для поиска квартир
            ApartmentSearch search = new ApartmentSearch();

            // Предлагаем пользователю ввести данные о квартирах
            Console.WriteLine("Введите данные о квартирах или нажмите Enter для завершения ввода:");

            // Цикл для ввода данных о квартирах
            while (true)
            {
                // Запрашиваем номер квартиры
                Console.Write("Номер квартиры: ");
                string input = Console.ReadLine();

                // Если ввода нет или пользователь нажал Enter, завершаем ввод данных
                if (string.IsNullOrEmpty(input))
                    break;

                int apartmentNumber;

                // Пытаемся преобразовать введенные данные в число (номер квартиры)
                if (!int.TryParse(input, out apartmentNumber))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число для номера квартиры.");
                    continue;
                }

                // Запрашиваем фамилию арендатора (если есть)
                Console.Write("Фамилия арендатора (если есть): ");
                string tenantName = Console.ReadLine();

                // Запрашиваем информацию о статусе аренды квартиры
                Console.Write("Является ли квартира арендованной? (yes/no): ");
                string isRentedInput = Console.ReadLine().ToLower();

                // Проверяем, является ли ответ пользователя "yes", если да, то квартира арендованная, иначе - свободная
                bool isRented = isRentedInput == "yes";

                // Создаем объект в зависимости от статуса аренды квартиры и добавляем его в список квартир
                if (isRented)
                {
                    search.AddFlat(new RentedFlat(apartmentNumber, tenantName));
                }
                else
                {
                    search.AddFlat(new EmptyFlat(apartmentNumber));
                }
            }

            // Выводим информацию о квартире, если пользователь хочет ее найти
            Console.WriteLine("\nПоиск квартиры:");

            // Запрашиваем номер квартиры для поиска
            Console.Write("Введите номер квартиры для поиска: ");
            int searchApartmentNumber;

            // Пытаемся преобразовать введенные данные в число (номер квартиры)
            if (int.TryParse(Console.ReadLine(), out searchApartmentNumber))
            {
                // Ищем квартиру по номеру
                Flat foundFlat = search.SearchByApartmentNumber(searchApartmentNumber);

                // Если квартира найдена, выводим информацию о ней
                if (foundFlat != null)
                {
                    Console.WriteLine("Найдена квартира:");
                    foundFlat.DisplayInfo();
                }
                else
                {
                    // Если квартира не найдена, сообщаем об этом
                    Console.WriteLine("Квартира с таким номером не найдена.");
                }
            }
            else
            {
                // В случае некорректного ввода номера квартиры сообщаем об этом
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число для номера квартиры.");
            }
            Console.ReadKey();
        }
    }
}

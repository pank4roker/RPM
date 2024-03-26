using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr_2_RMP
{
    abstract class Flat
    {
        public int ApartmentNumber { get; set; }
        public string TenantName { get; set; }

        public Flat(int apartmentNumber, string tenantName)
        {
            ApartmentNumber = apartmentNumber;
            TenantName = tenantName;
        }

        // Абстрактный метод для вывода информации о квартире
        public abstract void DisplayInfo();
    }
    // Класс для представления квартиры с арендатором
    class RentedFlat : Flat
    {
        public RentedFlat(int apartmentNumber, string tenantName) : base(apartmentNumber, tenantName)
        {
        }

        // Реализация метода для вывода информации о квартире
        public override void DisplayInfo()
        {
            Console.WriteLine($"Квартира №{ApartmentNumber} снимается арендатором {TenantName}");
        }
    }

    // Класс для представления пустой квартиры
    class EmptyFlat : Flat
    {
        public EmptyFlat(int apartmentNumber) : base(apartmentNumber, "Пусто")
        {
        }

        // Реализация метода для вывода информации о квартире
        public override void DisplayInfo()
        {
            Console.WriteLine($"Квартира №{ApartmentNumber} свободна");
        }
    }

    // Класс, организующий поиск квартир по номеру или фамилии
    class ApartmentSearch
    {
        private List<Flat> flats = new List<Flat>();

        // Метод для добавления квартиры
        public void AddFlat(Flat flat)
        {
            flats.Add(flat);
        }

        // Метод для поиска квартиры по номеру
        public Flat SearchByApartmentNumber(int apartmentNumber)
        {
            foreach (var flat in flats)
            {
                if (flat.ApartmentNumber == apartmentNumber)
                {
                    return flat;
                }
            }
            return null;
        }

        // Метод для поиска квартиры по фамилии арендатора
        public Flat SearchByTenantName(string tenantName)
        {
            foreach (var flat in flats)
            {
                if (flat.TenantName == tenantName)
                {
                    return flat;
                }
            }
            return null;
        }
    }
}

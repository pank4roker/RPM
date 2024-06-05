using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Name = "Обычный автомобиль", MaxSpeed = 140 };
            LuxuryCar luxuryCar = new LuxuryCar { Name = "Представительский автомобиль", MaxSpeed = 160 };

            Console.WriteLine("Информация об автомобилях до обновления:");
            Console.WriteLine(car.GetInfo());
            Console.WriteLine(luxuryCar.GetInfo());

            car.UpdateModel();
            luxuryCar.UpdateModel();

            Console.WriteLine("\nИнформация об автомобилях после обновления:");
            Console.WriteLine(car.GetInfo());
            Console.WriteLine(luxuryCar.GetInfo());

            Console.ReadLine();
        }
    }
}

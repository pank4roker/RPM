using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }

        public virtual double GetPrice()
        {
            return MaxSpeed * 100;
        }

        public virtual void UpdateModel()
        {
            MaxSpeed += 10;
        }

        public string GetInfo()
        {
            return $"Название: {Name}, Максимальная скорость: {MaxSpeed} км/ч, Стоимость: {GetPrice()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7pr
{
    class Composition
    {
        public string Product { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public Composition() { }
        public Composition(string product, int count, double price)
        {
            Product = product;
            Count = count;
            Price = price;
        }
        public double Prices()
        {
            return Count * Price;
        }
        public string Info()
        {
            return $"Продукт: {Product} Количество на складе:{Count} Цена за штуку:{Price} Общая стоимость:{Prices()}";
        }
    }
}

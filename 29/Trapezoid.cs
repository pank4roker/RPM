using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Trapezoid
    {
        int lowerBase;
        int upperBase;
        public Trapezoid() { }

        public Trapezoid(int lowerBase, int upperBase)
        {
            this.lowerBase = lowerBase;
            this.upperBase = upperBase;
        }
        public virtual void OutPut()
        {
            Console.Write($"Нижнее основание {lowerBase};Верхнее основоние {upperBase};");
        }
        public int HalfAmount()
        {
           return (lowerBase + upperBase)/2;
        }
    }
}

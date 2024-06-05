using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class NewTrapezoid : Trapezoid
    {
        int height;
        public NewTrapezoid(){}
        public NewTrapezoid(int lowerBase, int upperBase, int height) : base(lowerBase, upperBase)
        {
            this.height = height;
        }
        public override void OutPut()
        {
            base.OutPut();
            Console.Write($"Высота {height};Площадь: {Area()}");
        }
        public int Area()
        {
            return HalfAmount() * height;
        }
    }
}

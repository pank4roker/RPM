using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class LuxuryCar : Car
    {
        public override double GetPrice()
        {
            return MaxSpeed * 250;
        }

        public override void UpdateModel()
        {
            MaxSpeed += 5;
        }
    }
}

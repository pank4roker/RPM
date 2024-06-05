using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    class NewPerformance : Performance
    {
        private int yearOfWrite;
        public NewPerformance() { }
        public NewPerformance(string name, int numberBeginning, int numberEnd, int yearOfWrite) : base(name, numberBeginning, numberEnd)
        {
            YearOfWrite = yearOfWrite;
        }
        public int YearOfWrite { get => yearOfWrite; set => yearOfWrite = value; }
        public override double Func()
        {
            return base.Func() * ((double)DateTime.Now.Year - yearOfWrite + 1);
        }
        public override void OutPut()
        {
            base.OutPut();
            Console.WriteLine($"; Год написания пьесы: {yearOfWrite}; Общая функция: {Func()}");
        }
    }
}

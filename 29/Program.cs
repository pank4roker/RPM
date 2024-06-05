using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            Trapezoid trapezoid = new Trapezoid(2,5);
            trapezoid.OutPut();
            Console.WriteLine();
            NewTrapezoid newTrapezoid = new NewTrapezoid(5,6,5);
            newTrapezoid.OutPut();
            Console.ReadLine();
        }
    }
}

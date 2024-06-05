using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            Performance performance = new Performance("Вишневый сад",100,87);
            performance.OutPut();
            NewPerformance newPerformance = new NewPerformance("Вишневый сад", 100, 87,1903);
            newPerformance.OutPut();
            Console.ReadLine();
        }
    }
}

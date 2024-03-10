using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Composition> compositions = new List<Composition>();
            compositions.Add(new Composition("Корм", 10, 150));
            compositions.Add(new Composition("Ошейник", 20, 250));
            foreach(var elem in compositions)
            {
                WriteLine();
                Write(elem.Info());
            }
            ReadKey();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr_RPM_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sphere sphere = new Sphere(3);
            Cylinder cylinder = new Cylinder(2, 5);

            Console.WriteLine("Шар:");
            Console.WriteLine("Объем: " + sphere.Volume());
            Console.WriteLine("Площадь поверхности: " + sphere.SurfaceArea());

            Console.WriteLine("\nЦилиндр:");
            Console.WriteLine("Объем: " + cylinder.Volume());
            Console.WriteLine("Площадь поверхности: " + cylinder.SurfaceArea());
            Console.ReadKey();
        }
    }
}

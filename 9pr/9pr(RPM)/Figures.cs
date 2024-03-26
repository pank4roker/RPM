using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr_RPM_
{
    abstract class Figures
    {
        // Абстрактный метод для расчета объема
        public abstract double Volume();

        // Абстрактный метод для расчета площади поверхности
        public abstract double SurfaceArea();
    }
    class Sphere : Figures
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        public override double SurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
    }

    class Cylinder : Figures
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public override double SurfaceArea()
        {
            return (2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, 2));
        }
    }
}

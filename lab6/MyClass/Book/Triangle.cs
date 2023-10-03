using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Triangle(double side)
        {
            this.a = side;
            this.b = side;
            this.c = side;
        }

        public void PrintSides()
        {
            Console.WriteLine($"Стороны треугольника {a}, {b}, {c}");
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Square()
        {
            double hp = Perimeter() / 2;
            double result = Math.Sqrt( hp * (hp - a) * (hp - b) * (hp - c) );
            return result;
        }

        public bool Exists()
        {
            return a + b > c && b + c > a && c + a > b;
        }
    }
}

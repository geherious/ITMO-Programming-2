using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Operations
    {
        private static bool CheckTriangleIfExists(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || b + c <= a || c + a <= b)
            {
                return false;
            }
            return true;
        }
        public static double Square(double a, double b, double c)
        {
            if (!CheckTriangleIfExists(a, b, c)) return 0;
            double p = (a + b + c) / 2;
            double result = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return result;
        }
        public static double Square(double side)
        {
            double result = Math.Pow(side, 2) * Math.Sqrt(3) / 4;
            return result;
        }
    }
}

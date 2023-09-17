using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class EquatationSolver
    {
        public static int Solve(double a, double b, double c, out double x1, out double x2)
        {
            if (a == 0)
            {
                x1 = 0;
                x2 = 0;
                return -1;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                x1 = 0;
                x2 = 0;
                return -1;
            }
            else if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return 0;
            }
            else
            {
                x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                return 1;
            }
        }
    }
}

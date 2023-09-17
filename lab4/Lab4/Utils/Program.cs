using System.Drawing;

namespace Utils
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите коэффициенты a, b, c (через enter)");
            try
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }

            double x1, x2;
            int result = EquatationSolver.Solve(a ,b, c, out x1, out x2);
            if (result == -1)
            {
                Console.WriteLine($"a = {a}, b = {b}, c = {c}, корней нет");
            }
            else if (result == 0)
            {
                Console.WriteLine($"a = {a}, b = {b}, c = {c}, x1 = x2 = {x1:N2}");
            }
            else
            {
                Console.WriteLine($"a = {a}, b = {b}, c = {c}, x1 = {x1:N2}, x2 = {x2:N2}");
            }

        }
    }
}
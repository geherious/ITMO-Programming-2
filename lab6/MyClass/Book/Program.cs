namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(6);
            if (t1.Exists())
            {
                t1.PrintSides();
                Console.WriteLine($"Периметр треугольника: {t1.Perimeter()}");
                Console.WriteLine($"Площадь треугольника: {t1.Square()}");
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }

        }
    }
}
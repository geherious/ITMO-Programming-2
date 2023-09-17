namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите периметр:");
            double perimeter;
            try
            {
                string temp = Console.ReadLine();
                perimeter = double.Parse(temp);
                if (perimeter <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Число должно быть больше 0");
                return;
            }
            double side = perimeter / 3;
            double square = Math.Sqrt((perimeter / 2) * Math.Pow((perimeter / 2) - side, 3));
            Console.WriteLine("{0, 7} {1}", "Сторона", "Площадь");
            Console.WriteLine("{0, 7:0.##} {1, 7:0.##}", side, square);

        }
    }
}
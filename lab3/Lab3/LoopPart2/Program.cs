namespace LoopPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, x1, x2, y;
            try
            {
                Console.WriteLine("Введите левую границу");
                x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите правую границу");
                x2 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }

            Console.WriteLine("x\t\ty");

            x = x1;
            do
            {
                y = Math.Sin(x);
                Console.WriteLine("x:{0:N2}\t\ty:{1:N4}", x, y);
                x += 0.01;
            }
            while (x <= x2);
        }
    }



    }
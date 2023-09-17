using System;

namespace Aim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aim aim = new Aim();
            int result = 0;
            
            Console.WriteLine("Центр мишени: X={0}, Y={1}", aim.X, aim.Y);

            double x_noise, y_noise;
            Random random = new Random();
            x_noise = Math.Round(random.NextDouble() - 0.5, 2);
            y_noise = Math.Round(random.NextDouble() - 0.5, 2);

            Console.WriteLine("Помеха по X={0}, Y={1}", x_noise, y_noise);

            while (true)
            {
                Console.WriteLine("Совершить бросок (next) или остановить программу (stop)");
                string operation = Console.ReadLine();

                if (!operation.Equals("next") && !operation.Equals("stop"))
                {
                    Console.WriteLine("Некорректный ввод");
                    continue;
                }

                if (operation.Equals("stop"))
                {
                    Console.WriteLine("Ваш итоговой результат: {0}", result);
                    break;
                }

                else
                {
                    double x, y;
                    try
                    {
                        Console.WriteLine("Введите X");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите Y");
                        y = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Некорректный ввод");
                        continue;
                    }
                    int temp = aim.GetScore(x + x_noise, y + y_noise);
                    result += temp;
                    Console.WriteLine($"Вы попали в точку X={x + x_noise}, Y={y + y_noise}, ваш результат: {temp}");
                }
                
            }


        }

        class Aim
        {
            public double X { get; private set; }
            public double Y { get; private set; }

            public Aim()
            {
                Random random = new Random();
                X = Math.Round((random.NextDouble() - 0.5) * 4, 2);
                Y = Math.Round((random.NextDouble() - 0.5) * 4, 2);
            }

            public int GetScore(double x, double y)
            {
                double result = Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));

                if (result <= 1) return 10;
                else if (result <= 2) return 5;
                else if (result <= 3) return 1;
                else return 0;
            }
        }
    }
}
namespace LoopPart3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            try
            {
                Console.WriteLine("Введите первое число");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                b = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }

            Console.WriteLine($"НОД: {temp}");
        }
    }
}
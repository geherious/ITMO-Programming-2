namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, m, s;
            s = 0;
            try
            {
                Console.WriteLine("Введите k");
                k = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите m");
                m = int.Parse(Console.ReadLine());
                if (k > m) throw new Exception();
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }

            for (int i = 0; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                s += i;
            }

            Console.WriteLine($"Сумма чисел от 1 до 100, не включая заданный диапозон: {s}");
        }
    }
}
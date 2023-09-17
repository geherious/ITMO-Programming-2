namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint year;

            Console.WriteLine("Введите год");

            try
            {
                year = uint.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }

            if ((year % 4 == 0 || year % 400 == 0) && year % 100 != 0) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
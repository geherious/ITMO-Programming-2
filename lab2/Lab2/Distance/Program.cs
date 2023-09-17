namespace Distance
{
    internal class Program
    {
        public struct Distance
        {
            public uint foot;
            public uint inch;

            public Distance(uint foot, uint inch)
            {
                this.foot = foot + (inch / 12);
                this.inch = inch % 12;
            }

            public override string ToString()
            {
                return $"{foot}'-{inch}''";
            }

            public static Distance operator +(Distance a, Distance b)
            {
                return new Distance(a.foot + b.foot, a.inch + b.inch);
            }
        }
        static void Main(string[] args)
        {
            Distance distance1, distance2, distance3;
            uint foot1, inch1, foot2, inch2;
            try
            {
                Console.WriteLine("Введите количество футов для первого:");
                foot1 = uint.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество дюймов для первого:");
                inch1 = uint.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество футов для второго:");
                foot2 = uint.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество дюймов для второго:");
                inch2 = uint.Parse(Console.ReadLine());
            } catch (Exception)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            distance1.foot = foot1;
            distance1.inch = inch1;
            distance2.foot = foot2;
            distance2.inch = inch2;

            distance3 = distance1 + distance2;
            Console.WriteLine(distance3);
        }
    }
}
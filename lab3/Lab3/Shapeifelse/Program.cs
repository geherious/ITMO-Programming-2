namespace Shapeifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            try
            {
                Console.Write("x=");
                x = float.Parse(Console.ReadLine());
                Console.Write("y=");
                y = float.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            if (x * x + y * y < 9 && y > 0)
                Console.WriteLine("внутри");

            else if (x * x + y * y > 9 || y < 0)
                Console.WriteLine("вне");
            else Console.WriteLine("На границе");
        }
    }
}
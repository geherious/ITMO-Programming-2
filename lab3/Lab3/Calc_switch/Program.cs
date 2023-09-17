namespace Calc_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ok = true;
            double res = 0;
            double a, b;
            char op;
            try
            {
                Console.Write("A = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("OP = ");
                op = char.Parse(Console.ReadLine());
                Console.Write("B = ");
                b = double.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            if ((op.Equals('/') || op.Equals(':')) && b == 0)
            {
                Console.WriteLine("Нельзя делить на ноль");
                return;
            }
            switch (op)
            {
                case '+': res = a + b; break;
                case '-': res = a - b; break;
                case '*': res = a * b; break;
                case '/':
                case ':':
                    res = a / b; break;
                default: ok = false; break;
            }
            if (ok) Console.WriteLine("{0} {1} {2} = {3}", a, op, b, res);
            else Console.WriteLine("Операция не определена");
        }
    }
}
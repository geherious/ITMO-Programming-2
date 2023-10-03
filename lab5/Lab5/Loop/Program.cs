namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray;
            try
            {
                int n = int.Parse(Console.ReadLine());
                MyArray = new int[n];
                for (int i = 0; i < MyArray.Length; ++i)
                {
                    Console.Write("a[{0}]=", i);
                    MyArray[i] = int.Parse(Console.ReadLine());
                    foreach (int x in MyArray) Console.Write("{0} ", x);
                }
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
    }
}
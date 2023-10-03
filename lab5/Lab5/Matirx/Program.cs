namespace Matirx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину масссива");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Input(arr);
            int arrSum = ArraySum(arr);
            Console.WriteLine($"Сумма всех значений: {arrSum}");
            int arrPosSum = ArrayPositiveSum(arr);
            Console.WriteLine($"Сумма всех положительных значений: {arrPosSum}");
            int arrOddSum = ArrayOddPositionSum(arr);
            Console.WriteLine($"Сумма всех значений на четных позициях: {arrOddSum}");

            int min, minInd, max, maxInd, mult;
            min = FindMin(arr, out minInd);
            max = FindMax(arr, out maxInd);
            mult = GetMultBetweenMinMax(arr, minInd, maxInd);

            Console.WriteLine($"Максимальное число: {max} с индексом {maxInd}");
            Console.WriteLine($"Минимальное число: {min} с индексом {minInd}");
            Console.WriteLine($"Произведение чисел между максимальным и минимальным элементом включительно: {mult}");

        }
        static void Input(int[] arr)
        {
            for (int i  = 0; i < arr.Length; i++)
            {
                Console.Write($"Array[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (int i in arr) Console.Write($"{i} ");
        }

        static int ArraySum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        static int ArrayPositiveSum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                if (i > 0) sum += i;
            }
            return sum;
        }
        
        static int ArrayOddPositionSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0 ; i < arr.Length ; i++)
            {
                if (i % 2 == 0) sum += arr[i];
            }
            return sum;
        }

        static int FindMax(int[] arr, out int index)
        {
            int max = -int.MaxValue;
            index = -1;
            for (int i = 0 ;i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            return max;
        }

        static int FindMin(int[] arr, out int index)
        {
            int min = int.MaxValue;
            index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }
            return min;
        }

        static int GetMultBetweenMinMax(int[] arr, int min, int max)
        {
            int result = 1;
            for (int i = min ; i <= max ; i++)
            {
                result *= arr[i];
            }
            return result;
        }
    }
}
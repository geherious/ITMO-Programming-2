﻿namespace MatrixMultiply
{
    internal class Program
    {
        static void Main()
        {
            int[,] a = new int[2, 2];
            Input(a);
            int[,] b = new int[2, 2];
            Input(b);
            int[,] result;
            result = Multiply(a, b);
            Output(result);
        }

        private static void Output(int[,] result)
        {
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    Console.Write("{0} ", result[r, c]);
                }
                Console.WriteLine();
            }
        }
        private static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];
            return result;
        }
        private static void Input(int[,] a)
        {
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    Console.Write("Enter value for [{0},{1}] : ", r, c);
                    string s = System.Console.ReadLine();
                    a[r, c] = int.Parse(s);
                }
            }
            Console.WriteLine();
        }
    }
}
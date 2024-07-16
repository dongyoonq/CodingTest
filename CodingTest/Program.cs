using System;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var X = int.Parse(Console.ReadLine());

            FindX(X);
        }

        static void FindX(int X)
        {
            int count = 0;
            int n = 1;
            while (X != 0)
            {
                n = n << 1;

                if (X < n)
                {
                    X -= (n >> 1);
                    n = 1;
                    count++;
                }
            }

            Console.WriteLine($"{count}");
        }
    }
}

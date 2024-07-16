using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1010
{
    public void Solve()
    {
        var tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var read = Console.ReadLine().Split(' ');
            var n = int.Parse(read[0]);
            var m = int.Parse(read[1]);

            var result = Factorial(m) / (Factorial(n) * Factorial(m - n));
            Console.WriteLine($"{result}");
        }

        BigInteger Factorial(int n)
        {
            if (n == 0)
                return 1;

            BigInteger result = 1;
            for (int i = n; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1009
{
    public void Solve()
    {
        var tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var read = Console.ReadLine().Split(' ');
            var a = int.Parse(read[0]);
            var b = int.Parse(read[1]);

            int res = a;
            for (int i = 1; i < b; i++)
            {
                res = res * a % 10;
            }

            if (res % 10 == 0)
                Console.WriteLine($"10");
            else
                Console.WriteLine($"{res % 10}");
        }
    }
}
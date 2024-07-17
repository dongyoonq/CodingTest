using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1094
{
    public void Solve()
    {
        var X = int.Parse(Console.ReadLine());

        FindX(X);
    }

    void FindX(int X)
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
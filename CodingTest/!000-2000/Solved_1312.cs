using System;
using System.Collections.Generic;
using System.Linq;

public class Solved_1312
{
    public void Solve()
    {
        var splInt = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int A = splInt[0];
        int B = splInt[1];
        int N = splInt[2];

        var r = A % B;
        var result = 0;
        for (int i = 0; i < N; i++)
        {
            r *= 10;
            result = r / B;
            r %= B;
        }

        Console.WriteLine(result);
    }
}
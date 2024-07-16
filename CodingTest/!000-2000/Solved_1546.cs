using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1546
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        float[] num = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
        float max = num[0];
        foreach (var item in num)
        {
            if (max < item)
                max = item;
        }

        float sum = 0;
        foreach (var item in num)
            sum += item / max * 100;

        Console.WriteLine(sum / n); // 평균 출력
    }
}
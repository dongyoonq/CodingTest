using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Solved_1268
{
    private const int GRADE_COUNT = 5;
    public void Solve()
    {
        var n = int.Parse(Console.ReadLine());
        var list = new int[n, GRADE_COUNT];

        for (int i = 0; i < n; i++)
        {
            var gradeList = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (int j = 0; j < GRADE_COUNT; j++)
            {
                list[i, j] = gradeList[j];
            }
        }

        var countMap = new int[n];

        for (int i = 0; i < n; i++)
        {
            bool[] seen = new bool[n];

            for (int j = 0; j < GRADE_COUNT; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (i != k && list[i, j] == list[k, j] && !seen[k])
                    {
                        countMap[i]++;
                        seen[k] = true;
                    }
                }
            }
        }

        int maxCount = countMap.Max();
        int result = Array.IndexOf(countMap, maxCount) + 1;

        Console.WriteLine(result);
    }
}
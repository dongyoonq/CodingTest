using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1152
{
    public void Solve()
    {
        string[] str = Console.ReadLine().Split();
        int cnt = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (string.IsNullOrEmpty(str[i]))
            {
                continue;
            }
            else
                cnt++;
        }
        Console.WriteLine(cnt);
    }
}
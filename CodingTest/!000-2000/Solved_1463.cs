using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1463
{
    /*
        1 0
        2 1
        3 1
        4 2
        5 3
        6 2
        7 3
        8 3
        9 2
        10 4
        11 5
     */

    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        int[] dp = new int[n + 1];

        dp[1] = 0; // 1은 이미 1이므로 연산이 필요 없음

        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + 1; // 1을 빼는 연산을 우선 적용

            if (i % 2 == 0)
            {
                dp[i] = Math.Min(dp[i], dp[i / 2] + 1); // 2로 나누는 경우
            }

            if (i % 3 == 0)
            {
                dp[i] = Math.Min(dp[i], dp[i / 3] + 1); // 3으로 나누는 경우
            }
        }

        Console.WriteLine(dp[n]);
    }
}
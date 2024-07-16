using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1316
{
    public void Solve()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                bool[] chk = new bool[26];
                bool check = false;
                int last_idx = 0, cur_idx = 0;
                string str = Console.ReadLine();

                for (int j = 0; j < str.Length; j++)
                {
                    cur_idx = str[j] - 'a';

                    if (!chk[cur_idx])
                    {
                        chk[cur_idx] = true;
                    }
                    else
                    {
                        if (cur_idx != last_idx)
                            check = true;
                    }

                    last_idx = cur_idx;
                }

                if (!check)
                    cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
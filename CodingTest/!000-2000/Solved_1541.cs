using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1541
{
    public void Solve()
    {
        string input = Console.ReadLine();
        string[] tmp = input.Split('-');
        int cnt = 0;
        foreach (string strNum in tmp[0].Split('+'))
            cnt += int.Parse(strNum);

        if (tmp.Length == 0)
            Console.WriteLine(cnt);
        else
        {
            for (int i = 1; i < tmp.Length; i++)
            {
                string[] tmp2 = tmp[i].Split('+');
                foreach (string strNum in tmp2)
                    cnt -= int.Parse(strNum);
            }
            Console.WriteLine(cnt);
        }

    }
}
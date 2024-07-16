using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Solved_1157
{
    public void Solve()
    {
        int[] chk = new int[26];
        char[] input = Console.ReadLine().ToCharArray();
        for (int i = 0; i < input.Length; i++) // 소문자 -> 대문자
        {
            if (input[i] > 90)
            {
                input[i] = Convert.ToChar(input[i] - 32);
            }
        }

        for (int i = 0; i < input.Length; i++)
            chk[input[i] - 65]++;

        int index = 0;
        bool flag = false;
        int max = chk.Max();

        for (int i = 0; i < chk.Length; i++)
        {
            if (flag)
            {
                if (chk[i] == max)
                {
                    index = -1;
                    break;
                }
            }
            else
            {
                if (chk[i] == max)
                {
                    index = i;
                    flag = true;
                }
            }
        }

        if (index == -1)
            Console.WriteLine("?");
        else
            Console.WriteLine(Convert.ToChar(index + 65));
    }
}
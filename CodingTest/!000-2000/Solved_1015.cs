using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Solved_1015
{
    public void Solve()
    {
        int tc = int.Parse(Console.ReadLine());

        int[] ac = new int[tc];
        int[] result = new int[tc];
        bool[] chkPoint = new bool[tc];
        var read = Console.ReadLine().Split(' ');
        for (int i = 0; i < read.Length; i++)
        {
            ac[i] = int.Parse(read[i]);
        }

        int max = ac.Max() + 1;
        for (int i = 0; i < ac.Length; i++)
        {
            int min = max;
            int select = 0;
            for (int j = 0; j < ac.Length; j++)
            {
                if (chkPoint[j] == true)
                    continue;

                if (min > ac[j])
                {
                    min = ac[j];
                    select = j;
                }
            }

            result[select] = i;
            chkPoint[select] = true;
        }

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write($"{result[i]} ");
        }
    }
}
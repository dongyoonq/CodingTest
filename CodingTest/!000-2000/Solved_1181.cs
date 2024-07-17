using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Solved_1181
{
    static List<string> list = new List<string>();

    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        while (n-- > 0)
        {
            list.Add(Console.ReadLine());
        }

        list = list.Distinct().ToList();
        list.Sort((a, b) =>
        {
            if (a.Length > b.Length)
                return 1;
            else if (a.Length < b.Length)
                return -1;
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > b[i])
                        return 1;
                    else if (a[i] < b[i])
                        return -1;
                    else
                        continue;
                }
            }

            return 0;
        });

        foreach (var item in list)
            Console.WriteLine($"{item}");
    }
}
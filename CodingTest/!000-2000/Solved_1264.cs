using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Solved_1264
{
    public void Solve()
    {
        while (true)
        {
            string read = Console.ReadLine().ToLower();
            if (read.Equals("#"))
                break;

            int count = read.Count(x => x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u');
            Console.WriteLine($"{count}");
        }
    }
}
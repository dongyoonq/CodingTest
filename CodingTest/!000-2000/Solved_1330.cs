using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1330
{
    public void Solve()
    {
        string[] str = Console.ReadLine().Split();
        int a = int.Parse(str[0]);
        int b = int.Parse(str[1]);
        if (a < b)
            Console.WriteLine("<");
        else if (a > b)
            Console.WriteLine(">");
        else if (a == b)
            Console.WriteLine("==");
    }
}
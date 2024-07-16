using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1008
{
    public void Solve()
    {
        string str = Console.ReadLine();
        string[] tmp = str.Split(' ');
        int a = int.Parse(tmp[0]);
        int b = int.Parse(tmp[1]);
        Console.WriteLine((double)a / b);
    }
}
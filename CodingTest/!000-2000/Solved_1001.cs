using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solved_1001
{
    public void Solve()
    {
        string str = Console.ReadLine();
        string[] tmp = str.Split(' ');
        int a = int.Parse(tmp[0]);
        int b = int.Parse(tmp[1]);
        Console.WriteLine(a - b);
    }
}
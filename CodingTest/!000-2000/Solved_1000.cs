using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solved_1000
{
    public void Solve()
    {
        string str = Console.ReadLine();
        string[] tmp = str.Split(' ');
        int a = int.Parse(tmp[0]);
        int b = int.Parse(tmp[1]);
        if (a <= 0 || b >= 10)
        {
            Console.WriteLine("조건오류 A > 0, B < 10");
        }
        else
        {
            Console.WriteLine(a + b);
        }
    }
}
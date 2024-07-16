using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solved_1003
{
    public void Solve()
    {
        int testcase = 0;
        var str = Console.ReadLine();
        if (int.TryParse(str, out testcase))
        {
            while (testcase > 0)
            {
                str = Console.ReadLine();
                if (int.TryParse(str, out int n))
                {
                    Fibonnachi(n);
                }

                testcase--;
            }
        }
    }

    void Fibonnachi(int n)
    {
        int a = 0;
        int b = 1;
        int c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        if (n == 0)
        {
            Console.WriteLine($"1 0");
            return;
        }
        else
        {
            Console.WriteLine($"{a} {b}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Solved_1193
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        int start = 0;
        int adder = 0;
        while (true)
        {
            adder++;
            start += adder;

            if (n <= start)
            {
                int left = 1;
                int right = 1;
                if (adder % 2 == 0)
                    right = adder;
                else
                    left = adder;

                FindNumber(start - (adder - 1), n, left, right, left > right);

                break;
            }
        }
    }

    void FindNumber(int current, int target, int left, int right, bool leftStart)
    {
        if (current == target)
        {
            Console.WriteLine($"{left}/{right}");
            return;
        }

        if (leftStart)
            FindNumber(++current, target, --left, ++right, leftStart);
        else
            FindNumber(++current, target, ++left, --right, leftStart);
    }
}
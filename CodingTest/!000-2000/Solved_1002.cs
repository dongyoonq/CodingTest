using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solved_1002
{
    public void Solve()
    {
        int casenum = int.Parse(Console.ReadLine());
        while (casenum > 0)
        {
            int count = 0;
            string info = Console.ReadLine();
            string[] tmp = info.Split(' ');
            int x1 = int.Parse(tmp[0]);
            int y1 = int.Parse(tmp[1]);
            int d1 = int.Parse(tmp[2]);
            int x2 = int.Parse(tmp[3]);
            int y2 = int.Parse(tmp[4]);
            int d2 = int.Parse(tmp[5]);
            double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            int dissum = d1 + d2;
            int dissub = Math.Abs(d1 - d2);

            if (dist != 0)
            {
                if (dissum == dist)
                {
                    count++;
                }
                else if (dissub == dist)
                {
                    count++;
                }
                else if (dissum < dist)
                {
                    count += 0;
                }
                else if (dissub > dist)
                {
                    count += 0;
                }
                else
                {
                    count += 2;
                }
            }
            else
            {
                if (d1 == d2)
                {
                    count = -1;
                }
                else
                {
                    count += 0;
                }
            }

            Console.WriteLine(count);
            casenum--;

        }
    }
}
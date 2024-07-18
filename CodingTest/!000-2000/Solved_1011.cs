using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1011
{
    /*  PATTERN
        1 	1 1	  
        2 	2 11
        3 	3 111  	
        4 	3 121  
        5 	4 1211  
        6 	4 1221  
        7 	5 12211  
        8 	5 12221  
        9 	5 12321 
        10 	6 123211
     */

    public void Solve()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var read = Console.ReadLine().Split(' ');
            long start = long.Parse(read[0]);
            long end = long.Parse(read[1]);

            var dist = end - start;
            var r = (long)Math.Sqrt(dist);

            if (IsDoubleNum(dist))
                Console.WriteLine(2 * r - 1);
            else if (!IsDoubleNum(dist) && dist <= r * (r + 1))
                Console.WriteLine(2 * r);
            else
                Console.WriteLine(2 * r + 1);
        }
    }

    bool IsDoubleNum(long num)
    {
        var r = (long)Math.Sqrt(num);
        var pow = r * r;
        return pow.Equals(num);
    }
}
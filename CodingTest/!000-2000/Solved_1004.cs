using System;
using System.Collections.Generic;
using System.Numerics;

public class Solved_1004
{
    public void Solve()
    {
        var tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var read_1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var start = new Vector2(read_1[0], read_1[1]);
            var end = new Vector2(read_1[2], read_1[3]);

            List<(Vector2, int)> list = new List<(Vector2, int)>();

            var n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                var read_2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var center = new Vector2(read_2[0], read_2[1]);
                var rad = read_2[2];
                list.Add((center, rad));
            }

            int count = 0;
            foreach (var item in list)
            {
                if (!(IsContains(item.Item1.X, start.X, item.Item1.Y, start.Y, item.Item2) &&
                    IsContains(item.Item1.X, end.X, item.Item1.Y, end.Y, item.Item2)) &&
                    (IsContains(item.Item1.X, start.X, item.Item1.Y, start.Y, item.Item2) ||
                    IsContains(item.Item1.X, end.X, item.Item1.Y, end.Y, item.Item2)))
                {
                    count++;
                }
            }

            Console.WriteLine($"{count}");
        }
    }

    bool IsContains(double x0, double x, double y0, double y, double r)
    {
        return Math.Sqrt(Math.Pow(x0 - x, 2) + Math.Pow(y0 - y, 2)) < r;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class Solved_1817
{
    public void Solve()
    {
        var readStr = Console.ReadLine().Split(' ');
        var n = int.Parse(readStr[0]);
        var m = int.Parse(readStr[1]);

        if (n == 0)
        {
            Console.WriteLine("0");
            return;
        }

        var list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).ToList();
        list.Sort((a, b) => a.CompareTo(b));

        int boxCount = 0;
        bool[] checkList = new bool[list.Count];

        while (checkList.Any(x => x == false))
        {
            int current = 0;
            var removeList = new List<int>();

            if (list.Count == 1)
            {
                if (list[0] <= m)
                    boxCount++;
                break;
            }

            for (int i = 0; i < list.Count; ++i)
            {
                if (current + list[i] < m)
                {
                    current += list[i];
                    removeList.Add(i);
                    checkList[i] = true;
                }
                else if (current + list[i] == m)
                {
                    current = 0;
                    removeList.Add(i);
                    checkList[i] = true;
                    boxCount++;
                }
                else
                {
                    boxCount++;
                    break;
                }
            }

            var newList = new List<int>();
            for (int i = 0; i < list.Count; ++i)
            {
                if (removeList.Contains(i))
                    continue;
                newList.Add(list[i]);
            }
            list.Clear();
            list = new List<int>(newList);

            if (newList.Count == 0)
                break;
        }

        Console.WriteLine($"{boxCount}");
    }
}
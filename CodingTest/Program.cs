using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve();
        }

        static void Solve()
        {
            var readStr = Console.ReadLine().Split(' ');
            var n = int.Parse(readStr[0]);
            var m = int.Parse(readStr[1]);

            if (n == 0)
            {
                Console.WriteLine("0");
                return;
            }

            var list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int boxCount = 0;
            int currentBoxCapacity = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (currentBoxCapacity + list[i] <= m)
                {
                    currentBoxCapacity += list[i];
                }
                else
                {
                    boxCount++;
                    currentBoxCapacity = list[i];
                }
            }

            if (currentBoxCapacity > 0)
                boxCount++;

            Console.WriteLine(boxCount);
        }
    }
}

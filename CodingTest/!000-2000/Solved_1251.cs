using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

public class Solved_1251
{
    public void Solve()
    {
        string input = Console.ReadLine();

        int left = 1;   // 삼등분 해야되는 왼쪽 값
        int right = 2;  // 삼등분 해야하는 오른쪽 값
        int length = input.Length;
        List<string> result = new List<string>();

        while (true)
        {
            char[] a = new char[left];
            Array.Copy(input.ToArray(), 0, a, 0, left);
            Array.Reverse(a);

            char[] b = new char[right - left];
            Array.Copy(input.ToArray(), left, b, 0, right - left);
            Array.Reverse(b);

            char[] c = new char[length - right];
            Array.Copy(input.ToArray(), right, c, 0, length - right);
            Array.Reverse(c);

            result.Add(new string(a) + new string(b) + new string(c));

            right++;

            if (right >= length) // right의 값이 총 길이를 넘기면 left값 증가시키고 right값을 left+1로 초기화
            {
                left++;
                right = left + 1;

                if (right >= length) // 초기화 후에도 length 보다 크다면 반복문 종료
                    break;
            }
        }

        result.Sort();

        Console.WriteLine(result[0]);
    }
}
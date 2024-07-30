using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solved_11068
{
    public void Solve()
    {
        var tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var num = int.Parse(Console.ReadLine());

            bool result = false;
            for (int i = 2; i <= 64; i++)
            {
                if (IsFind(num, i))
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine(result ? 1 : 0);
        }
    }

    public bool IsFind(int num, int n)
    {
        List<int> list = new List<int>();
        while (num > 0)
        {
            list.Add(num % n);
            num /= n;
        }

        var center = list.Count / 2;
        for (int i = 0; i < center; ++i)
        {
            if (list[i] != list[list.Count - 1 - i])
                return false;
        }

        return true;
    }

    // 내풀이
    //private readonly char[] Base64Chars =
    //{
    //        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
    //        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
    //        'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
    //        'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '-', '_', '+', '=', '!', '@', '#', '$',
    //        '%', '^', '&', '*'
    //};

    //public void Solve()
    //{
    //    var tc = int.Parse(Console.ReadLine());
    //    while (tc-- > 0)
    //    {
    //        var num = int.Parse(Console.ReadLine());

    //        bool result = false;
    //        for (int i = 2; i <= 64; i++)
    //        {
    //            if (IsFind(num, i))
    //            {
    //                result = true;
    //                break;
    //            }
    //        }

    //        Console.WriteLine(result ? 1 : 0);
    //    }
    //}

    //public bool IsFind(int num, int n)
    //{
    //    if (num == 0)
    //        return true;

    //    // 숫자를 주어진 진법으로 변환
    //    StringBuilder sb = new StringBuilder();
    //    while (num > 0)
    //    {
    //        sb.Insert(0, Base64Chars[num % n]);
    //        num /= n;
    //    }

    //    var str = sb.ToString();

    //    // 문자열을 역순으로 변환
    //    char[] charArray = str.ToCharArray();
    //    Array.Reverse(charArray);
    //    string reversedStr = new string(charArray);

    //    // 원본 문자열과 역순 문자열 비교
    //    return str.Equals(reversedStr);
    //}
}
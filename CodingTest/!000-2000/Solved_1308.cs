using System;
using System.Collections.Generic;
using System.Linq;

public class Solved_1308
{
    private readonly int[] days = new int[12]
    { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public void Solve()
    {
        var start = new int[3];
        var end = new int[3];
        var readSpl_1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var readSpl_2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        for (int i = 0; i < start.Length; ++i)
        {
            start[i] = readSpl_1[i];
            end[i] = readSpl_2[i];
        }

        var startYear = start[0];
        var startMon = start[1];
        var startDay = start[2];
        var endYear = end[0];
        var endMon = end[1];
        var endDay = end[2];

        // 1000년 이상 차이
        if (endYear - startYear > 1000 || (endYear - startYear == 1000 && endMon > startMon) ||
            (endYear - startYear == 1000 && endMon == startMon && endDay >= startDay))
        {
            Console.WriteLine("gg");
        }
        else
        {
            long startDaysAdd = FindingDays(startYear, startMon, startDay);
            long endDaysAdd = FindingDays(endYear, endMon, endDay);
            Console.WriteLine($"D-{endDaysAdd - startDaysAdd}");
        }
    }

    long FindingDays(int year, int month, int day)
    {
        long addDay = 0;
        for (int i = 1; i < year; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                addDay += days[j];
                if (j == 1 && IsYoon(i))
                    addDay += 1;
            }
        }

        for (int i = 0; i < month - 1; i++)
        {
            addDay += days[i];
            if (i == 1 && IsYoon(year))
                addDay += 1;
        }

        addDay += day;

        return addDay;
    }

    bool IsYoon(int year)
    {
        return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
    }
}
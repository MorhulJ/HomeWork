using System.Globalization;

namespace System;

public class Task5
{
    public static void Run(string i)
    {
        DateTime date = DateTime.ParseExact(i, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        
        string dayOfWeek = date.ToString("dddd", CultureInfo.InvariantCulture);
        
        int m = date.Month;
        string season = null;

        if (m == 12 || m == 1 || m == 2)
            season = "Winter";
        if (m >= 3 && m <= 5)
            season = "Spring";
        if (m >= 6 && m <= 8)
            season = "Summer";
        if (m >= 9 && m <= 11)
            season = "Autumn";

        Console.WriteLine($"{season} {dayOfWeek}");
    }
}
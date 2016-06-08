using System;

class WorkDay
{
    static int CountWorkDays(DateTime start, DateTime end)
    {
        int weekend = 0;
        int weekdays = 0;
        while (start <= end)
        {
            if ((int)start.DayOfWeek == 0 || (int)start.DayOfWeek == 6)
            {
                weekend++;
            }
            else
            {
                weekdays++;
            }
            start = start.AddDays(1);
        }
        return weekdays;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(CountWorkDays(new DateTime(2015, 1, 1), new DateTime(2015, 6, 20)));
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a year to check if it is leap: ");
        int year = Convert.ToInt32(Console.ReadLine());
        string isLeap = DateTime.IsLeapYear(year) ? "It is a leap year" : "It is not a leap year";
        Console.WriteLine(isLeap);
    }
}


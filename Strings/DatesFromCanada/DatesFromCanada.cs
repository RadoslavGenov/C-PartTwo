
namespace DatesFromCanada
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Globalization;

    class DatesFromCanada
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"C:\Users\rados\Desktop\C# Part 2\Strings\DatesFromCanada\TextFile1.txt");
            string text = file.ReadToEnd();

            string pattern = @"([0-3]{1}[0-1]{1}|[0-2]{1}[0-9]{1})\.(0{1}[0-9]{1}|1{1}[0-2]{1})\.(1{1}[0-9]{3}|2{1}0{1}[0-9]{2})";
            MatchCollection matches = Regex.Matches(text, pattern);
            file.Close();

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-CA");

            Console.WriteLine("Dates without Canadian Formating: ");
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

            Console.WriteLine("\nDates with Canadian Formating: ");
            DateTime canadaDate;
            foreach (var match in matches)
            {
                canadaDate = DateTime.ParseExact(match.ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                Console.WriteLine(canadaDate);
            }

        }
    }
}

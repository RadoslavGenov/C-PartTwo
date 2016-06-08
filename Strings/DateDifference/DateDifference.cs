using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first date: ");
            string first = Console.ReadLine();
            Console.WriteLine("Enter second date: ");
            string second = Console.ReadLine();

            DateTime start = DateTime.ParseExact(first, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(second, "d.MM.yyyy", CultureInfo.InvariantCulture);

            TimeSpan result = end.Subtract(start);
            Console.WriteLine(result.TotalDays);
        }
    }
}

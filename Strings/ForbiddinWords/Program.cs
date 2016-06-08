using System;
using System.Text.RegularExpressions;

namespace ForbiddinWords
{
    class Program
    {
        public static string myFunc(Match match)
        {
            return new string('*', match.Length);
        }
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string result = Regex.Replace(text, "(PHP|CLR|Microsoft)", myFunc);
            Console.WriteLine(result);
        }
    }
}

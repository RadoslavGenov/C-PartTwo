using System;
using System.Text.RegularExpressions;

namespace ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/2";

            //string protocolPattern = @".+[:]";
            //Match protocol = Regex.Match(url, protocolPattern);

            //string serverPattern = @"[//].*[\.].*?[^\/]*";
            //Match server = Regex.Match(url, serverPattern);

            //string resourcePattern = @"";

            Uri uri = new Uri(url);
            string protocol = uri.Scheme;
            string server = uri.Host;
            string resource = uri.LocalPath;
            Console.WriteLine(protocol);

        }
    }
}

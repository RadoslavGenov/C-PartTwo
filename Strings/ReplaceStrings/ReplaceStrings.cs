namespace ReplaceStrings
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceStrings
    {
        static void Main(string[] args)
        {
            string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string firstOut = Regex.Replace(input, "<a(.*?)\"", "[URL=");
            string secondOut = Regex.Replace(firstOut, "\">", "]");
            string final = Regex.Replace(secondOut, "(</a>)", "[/URL]");
            Console.WriteLine(final);
        }
    }
}

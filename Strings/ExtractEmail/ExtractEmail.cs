using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ExtractEmail
{
    class ExtractEmail
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\rados\Desktop\C# Part 2\Strings\ExtractEmail\text.txt");
            string file = stream.ReadToEnd();

            string pattern = @"\w*(@)(.*?)(\.)\w*";
            MatchCollection matches = Regex.Matches(file, pattern);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

            stream.Close();
        }
    }
}

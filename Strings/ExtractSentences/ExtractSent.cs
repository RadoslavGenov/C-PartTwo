
namespace ExtractSentences
{
    using System;
    using System.Text.RegularExpressions;
    class ExtractSent
    {
        static void Main(string[] args)
        {
            string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string pattern = @"[^.]*(\sin\s)[^.]*";
            MatchCollection matches = Regex.Matches(input, pattern);
            Console.WriteLine("Expression: {0} \n", input);
            Console.WriteLine("Sentences to extract which contains word: in \n");
            foreach (Match item in matches)
            {
                Console.WriteLine("Matched: {0} \n", item);
            }
        }
    }
}

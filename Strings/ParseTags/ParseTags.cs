using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ParseTags
{
    class ParseTags
    {
        public static string myFunc(Match match)
        {
            string current = match.ToString().ToUpper();
            return Regex.Replace(current, "<(.*?)>", string.Empty);    
        }
        static void Main(string[] args)
        {
            string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string result = Regex.Replace(input, "<upcase>(.*?)</upcase>", myFunc);
            Console.WriteLine(result);  
        }
    }
}

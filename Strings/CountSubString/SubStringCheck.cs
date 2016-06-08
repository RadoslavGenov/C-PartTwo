using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubString
{
    class SubStringCheck
    {
        static int FindSubString(string input, string subString)
        {
            StringComparison comp = StringComparison.OrdinalIgnoreCase;
            int found = 0;
            int totalFinds = 0;
            for (int i = 0; i < input.Length; i++)
            {
                found = input.IndexOf(subString, i, comp);
                if (found >= 0)
                {
                    totalFinds++;
                    i = found;
                }
            }
            return totalFinds;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string subString = Console.ReadLine();
            Console.WriteLine(FindSubString(text, subString));
        }
    }
}

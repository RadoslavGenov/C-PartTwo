using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        public static bool IsPalindrome(string input)
        {
            for (int i = 0, e = input.Length - 1; i < input.Length / 2; i++, e--)
            {
                if (input[i] != input[e])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            List<string> text = new List<string>();
            using (StreamReader file = new StreamReader(@"C:\Users\rados\Desktop\C# Part 2\Strings\Palindromes\TextFile1.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    text.Add(line);
                }
            }
            foreach (var str in text)
            {
                Console.WriteLine(IsPalindrome(str));
            }
        }
    }
}

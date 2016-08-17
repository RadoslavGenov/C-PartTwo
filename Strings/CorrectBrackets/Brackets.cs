using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Brackets
    {
        static bool CheckBrackets(string input)
        {
            int left = 0;
            int right = 0;
            foreach (char character in input)
            {
                if (character == '(')
                {
                    left++;
                }
                else if (character == ')')
                {
                    right++;
                }
            }
            return left == right;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = CheckBrackets(input) ? "Brackets are correct ! " : "Brackets are not correct !";
            Console.WriteLine(result);
        }
    }
}

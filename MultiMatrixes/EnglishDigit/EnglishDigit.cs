using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class EnglishDigit
    {
        static string EnglishDigitLast(int word)
        {
            int lastDigit = word % 10;
            string wordDigit;
            switch (lastDigit)
            {
                case 0:
                    wordDigit = "zero";
                    break;
                case 1:
                    wordDigit = "one";
                    break;
                case 2:
                    wordDigit = "two";
                    break;
                case 3:
                    wordDigit = "three";
                    break;
                case 4:
                    wordDigit = "four";
                    break;
                case 5:
                    wordDigit = "five";
                    break;
                case 6:
                    wordDigit = "six";
                    break;
                case 7:
                    wordDigit = "seven";
                    break;
                case 8:
                    wordDigit = "eight";
                    break;
                case 9:
                    wordDigit = "nine";
                    break;
                default:
                    wordDigit = "no match";
                    break;
            }
            return wordDigit;
        }
        static void Main(string[] args)
        {
            int test = 543;
            string result = EnglishDigitLast(test);
            Console.WriteLine(result);
        }
    }
}

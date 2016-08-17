using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeChars
{
    class UnicodeChars
    {
        public static string Converter(string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char character in input)
            {
                result.Append(string.Format("\\u{0:X4}",Convert.ToUInt32(character)));
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Converter(input));
        }
    }
}

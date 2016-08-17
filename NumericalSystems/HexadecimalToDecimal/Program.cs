using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimal
{
    class Program
    {
        static long HtoD(string hexNumber)
        {
            long decimalNumber = 0;
            for (int i = 0; i < hexNumber.Length; i++)
            {
                var digit = 0;
                if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
                {
                    digit = hexNumber[i] - '0';
                }
                else if(hexNumber[i] >= 'A' && hexNumber[i] <= 'F')
                {
                    digit = hexNumber[i] - 'A' + 10;
                }
                decimalNumber += digit * (long)Math.Pow(16, hexNumber.Length - 1 - i);
            }
            return decimalNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(HtoD("ABCDD"));
        }
    }
}

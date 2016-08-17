using System;

namespace BinaryToDecimal
{
    class BtoD
    {
        static double recursiveBinarytoDecimal(string binaryDigit, int i = 0)
        {
            double dec = 0;
            if (i < binaryDigit.Length)
            {
                if (binaryDigit[i] == '1')
                {
                    dec += Math.Pow(2, binaryDigit.Length - i - 1);
                }
                return dec + recursiveBinarytoDecimal(binaryDigit, ++i);
            }
            return dec;
        }
        static double BinarytoDeci(string binaryDigit)
        {
            double decimalNumber = 0;
            for (int i = 0; i < binaryDigit.Length; i++)
            {
                int digit = binaryDigit[i] - '0';
                decimalNumber += digit * Math.Pow(2, binaryDigit.Length - 1 - i);
            }
            return decimalNumber;
        }
        static void Main(string[] args)
        {
            string binS = "1010101010101010101";
            Console.WriteLine(BinarytoDeci(binS));
            Console.WriteLine(recursiveBinarytoDecimal(binS));
        }
    }
}

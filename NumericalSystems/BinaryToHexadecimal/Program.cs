using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class Program
    {
        static string BinaryToHex(int binaryDigit)
        {
            return DtoH(BinarytoDeci(binaryDigit));
        }
        static string DtoH(int digit)
        {
            StringBuilder hex = new StringBuilder();
            do
            {
                int remainder = digit % 16;
                digit /= 16;
                switch (remainder)
                {
                    case 10:
                        hex.Append('A');
                        break;
                    case 11:
                        hex.Append('B');
                        break;
                    case 12:
                        hex.Append('C');
                        break;
                    case 13:
                        hex.Append('D');
                        break;
                    case 14:
                        hex.Append('E');
                        break;
                    case 15:
                        hex.Append('F');
                        break;
                    default:
                        hex.Append(remainder);
                        break;
                }
            } while (digit > 15);
            
            switch (digit)
            {
                case 10:
                    hex.Append('A');
                    break;
                case 11:
                    hex.Append('B');
                    break;
                case 12:
                    hex.Append('C');
                    break;
                case 13:
                    hex.Append('D');
                    break;
                case 14:
                    hex.Append('E');
                    break;
                case 15:
                    hex.Append('F');
                    break;
                default:
                    hex.Append(digit);
                    break;
            }

            string hexadecimal = hex.ToString();
            char[] charArr = hexadecimal.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
        static int BinarytoDeci(int binaryDigit)
        {
            int dec = 0;
            for (int i = binaryDigit, pow = 0; i != 0; pow++)
            {
                dec += (int)((i % 10) * Math.Pow(2, pow));
                i /= 10;
            }
            return dec;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryToHex(10001111));
        }
    }
}

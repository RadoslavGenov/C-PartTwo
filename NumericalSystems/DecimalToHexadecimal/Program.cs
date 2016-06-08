using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class Program
    {
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
        static void Main(string[] args)
        {
            string hex = DtoH(255);
            Console.WriteLine(hex);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class Program
    {
        static void HexToBinary(string hexDigit)
        {
            DtoB(HtoD(hexDigit));
        }
        static int HtoD(string hexDigit)
        {
            int digit = 0;
            for (int i = hexDigit.Length - 1; i >= 0; --i)
            {
                switch (hexDigit[i])
                {
                    case '0':
                        digit += (int)(0 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case '1':
                        digit += (int)(1 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case '2':
                        digit += (int)(2 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case '3':
                        digit += (int)(3 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case '4':
                        digit += (int)(4 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case '5':
                        digit += (int)(5 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case '6':
                        digit += (int)(6 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case '7':
                        digit += (int)(7 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case '8':
                        digit += (int)(8 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case '9':
                        digit += (int)(9 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case 'A':
                        digit += (int)(10 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case 'B':
                        digit += (int)(11 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case 'C':
                        digit += (int)(12 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case 'D':
                        digit += (int)(13 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case 'E':
                        digit += (int)(14 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    case 'F':
                        digit += (int)(15 * Math.Pow(16, hexDigit.Length - i - 1));
                        break;
                    default:
                        break;
                }
            }
            return digit;
        }
        static void DtoB(int digit)
        {
            var temp = new List<int>();
            for (int i = digit; i > 0;)
            {
                temp.Add(i % 2);
                i /= 2;
            }
            temp.Reverse();
            foreach (var item in temp)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            HexToBinary("FFF0");
        }
    }
}

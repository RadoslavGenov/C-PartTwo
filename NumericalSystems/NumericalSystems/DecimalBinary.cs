using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSystems
{
    class DecimalBinary
    {
        static string recursionDtoB(int digit, string s = "")
        {
            return (digit == 0) ? s : recursionDtoB(digit / 2, digit % 2 + s);
        }
        static void DtoB(int digit)
        {
            var temp = new List<int>();
            for (int i = digit; i > 0; )
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
            int decimalNum = int.Parse(Console.ReadLine());
            DtoB(decimalNum);
            Console.WriteLine(recursionDtoB(decimalNum));
        }
    }
}

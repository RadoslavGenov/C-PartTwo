using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class Program
    {
        static List<int> NumAsArray(int[] numOne, int[] numTwo)
        {
            List<int> result = new List<int>(Math.Max(numOne.Length, numTwo.Length));
            int carry = 0;
            for (int i = 0; i < result.Capacity; i++)
            {
                int num = (i < numOne.Length ? numOne[i] : 0) + (i < numTwo.Length ? numTwo[i] : 0) + carry;
                carry = num / 10;
                result.Add(num % 10);
            }
            if (carry > 0) result.Add(carry);
            return result;
        }
        static void Main(string[] args)
        {
            var a = new[] { 1, 2 };
            var b = new[] { 1, 3 };
            var list = NumAsArray(a, b);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

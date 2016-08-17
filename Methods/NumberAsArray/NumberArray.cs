using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class NumberArray //adds to numbers represented as digits of arrays
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
            int[] one = new int[] { 1, 2, 3, 4, 5 };
            int[] two = new int[] { 5, 2, 3, 4, 5 };
            List<int> result = NumAsArray(one, two);
            result.Reverse();
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

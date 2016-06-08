using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbors
{
    class First
    {
        static int LargerThanFirst(int[] arr)
        {
            for (int index = 1; index < arr.Length - 1; index++)//go to array.Length - 1 since last index does not have two neighbors
            {
                if (arr[index - 1] < arr[index] && arr[index + 1] < arr[index])
                {
                    return index;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            var arr = new int[6]
            {
                1,2,3,4,4,4
            };
            int result = LargerThanFirst(arr);
            Console.WriteLine("Index = {0}", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbors
{
    class LTN
    {
        static bool Larger(int[] arr, int index)
        {
            if (index <= 0 || index >= arr.Length - 1)
            {   //if index is 0 or less OR index is greater or equal to the last index then it does not have 2 neighbors
                return false;
            }
            else 
            {   //check 
                if (arr[index - 1] < arr[index] && arr[index + 1] < arr[index])
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            var arr = new int[6]
            {
                1,2,3,2,5,4
            };
            bool result = Larger(arr, 4);
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class Count
    {
        static int Counter(int[] arr, int target)
        {
            int count = 0;
            foreach (int item in arr)
            {
                if (item == target)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            var arr = new int[10]
            {
                1,2,3,4,5,6,7,7,7,7
            };
            int results = Counter(arr, 5);
            Console.WriteLine(results);
        }
    }
}

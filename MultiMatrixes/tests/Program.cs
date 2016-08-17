using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][] { 
                new int[]{ 1, 2, 3, 4 },
                new int[]{ 3, 4, 5, 6}
            };

            int[][] arr2 = arr;
            arr2[0][0] = 0;
            Console.WriteLine(arr[0][0]);
        }
    }
}

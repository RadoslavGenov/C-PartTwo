using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a number K: ");
            int k = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            int index = Array.BinarySearch(arr, k);
            if (index < 0)
            {
                Console.WriteLine("The largest number that is less than or equal to {0} is arr[{1}] = {2}", k, size - 1, arr[size - 1]);
            }
            else
            {
                Console.WriteLine("The largest number that is less than or equal to {0} is arr[{1}] = {2}", k, index, arr[index]);
            }
        }
    }
}

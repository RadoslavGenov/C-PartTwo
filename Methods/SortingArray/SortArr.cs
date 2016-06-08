using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class SortArr
    {
        static void PrintArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static int[] Descending(int[] result)
        {
            for (int i = 0; i < result.Length ; i++)
            {
                result[i] = MaxElement(result, i, result.Length - 1, i);
            }
            return result;
        }
        static int[] Ascending(int[] result)
        {
            for (int i = result.Length - 1; i > 0; --i)
            {
                result[i] = MaxElement(result, 0, i, i);
            }
            return result;
        }
        static int MaxElement(int[] arr, int start, int end, int swapIndex = 0)
        {
            if (start < 0 || end > arr.Length - 1 || end < 0 || start > arr.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            int maxIndex = start;
            for (int i = start; i <= end; i++)
            {
                if (arr[maxIndex] < arr[i])
                {
                    maxIndex = i;
                }
            }
            int temp = arr[swapIndex];
            arr[swapIndex] = arr[maxIndex];
            arr[maxIndex] = temp;
            return arr[swapIndex];
        }
        static void Main(string[] args)
        {
            //int i = 0;
            //for (string line = null; (line = Console.ReadLine()) != string.Empty;)
            //    i += int.Parse(line);

            //Console.WriteLine("{0:00}",i);
            int[] arr = new int[] { 4, 3, 2, 7, 5, 12, -100, -50 };
            Console.WriteLine("Largest Element: {0}", MaxElement(arr, 0, arr.Length - 1));
            Console.Write("Descending Order: ");
            PrintArr(Descending(arr));
            Console.WriteLine();
            Console.Write("Ascending Order: ");
            PrintArr(Ascending(arr));
            Console.WriteLine();
        }
    }
}

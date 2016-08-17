using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByStringLength
{
    class SortBy
    {
        public static int partition(string[] arr, int lo, int hi)
        {
            int pivot = arr[hi].Length;
            int i = lo;
            for (int j = lo; j <= hi - 1; j++)
            {
                if (arr[j].Length <= pivot)
                {
                    string temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                    i++;
                }
            }
            string temp = arr[i];
            arr[i] = arr[hi];
            arr[hi] = temp;
            return i;
        }
        public static void quicksort(string[] arr, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = partition(arr, lo, hi);
                quicksort(arr, lo, p - 1);
                quicksort(arr, p + 1, hi);
            }
        }
        static void Main(string[] args)
        {
            var arr = new string[7]
            {"hhh", "askfjdkmcdkmfjdkf2421", "sd", "aksf", "r", "asfkjdj", "alsjfkjfkjsdfjds"};
            quicksort(arr, 0, arr.Length -1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

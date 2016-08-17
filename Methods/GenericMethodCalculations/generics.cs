using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodCalculations
{
    class generics
    {
        static T Minimum<T>(params T[] arr) where T : IComparable<T>
        {
            int min = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(arr[min]) < 0) { min = i; }
            }
            return arr[min];
        }
        static T Maximum<T>(params T[] arr) where T : IComparable<T>
        {
            int max = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(arr[max]) > 0) { max = i; }
            }
            return arr[max];
        }
        static T Average<T>(params T[] arr) where T : IComparable<T>
        {
            dynamic sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
        static T Sum<T>(params T[] arr) where T : IComparable<T>
        {
            dynamic sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static T Product<T>(params T[] arr) where T : IComparable<T>
        {
            dynamic product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }
        static void Main(string[] args)
        {
            int a = Minimum<int>(1, 2, 0, -304, 4, 5 );
            Console.WriteLine(a);
            int b = Maximum<int>(1, 2, 3, 4, 5, 123, 1, 2, 3);
            Console.WriteLine(b);
            int average = Average<int>(1, 2, 3, 4, 5);
            Console.WriteLine(average);
            int sum = Sum<int>(1, 2, 3, 4, 5);
            Console.WriteLine(sum);
            int product = Product<int>(1, 2, 3, 4);
            Console.WriteLine(product);
        }
    }
}

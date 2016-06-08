
namespace SumInts
{
    using System;

    class Program
    {
        public static uint SumOfIntegers(string numbers)
        {
            string[] arrNums = numbers.Split(' ');
            uint sum = 0;
            uint num;
            for (int i = 0; i < arrNums.Length; i++)
            {
                uint.TryParse(arrNums[i], out num);
                sum += num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfIntegers("43 68 9 23 318"));
        }
    }
}

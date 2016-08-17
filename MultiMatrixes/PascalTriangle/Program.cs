using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        private static int height;
        private static long[][] pascal;
        static void Main(string[] args)
        {
            height = 10;
            pascal = new long[height + 1][];

            for (int i = 0; i <= height; i++)
            {
                pascal[i] = new long[i + 1];
            }
            pascal[0][0] = 1;
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    pascal[row + 1][col] += pascal[row][col];
                    pascal[row + 1][col + 1] += pascal[row][col];
                }
            }
            for (int row = 0; row <= height; row++)
            {
                Console.Write("".PadLeft((height - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0, 4}", pascal[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}

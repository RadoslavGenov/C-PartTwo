using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0}, {1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int best = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) -2 ; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) -2 ; col++)
            {
                int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] + matrix[row, col + 1] + matrix[row + 2, col + 2] +
                    matrix[row, col + 2] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col + 1];
                if (sum > best)
                {
                    best = sum;
                }
            }
        }
        Console.WriteLine("Largest sum is: {0}", best);
    }
}


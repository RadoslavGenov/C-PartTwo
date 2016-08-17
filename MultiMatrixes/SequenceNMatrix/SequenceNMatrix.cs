using System;

namespace SequenceNMatrix
{
    class SequenceNMatrix
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            string[,] matrix = new string[N, M];

            string maxString = "";
            int maxCount = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int countX = 0;
                    int countY = 0;
                    while (row + countX < matrix.GetLength(0))
                    {
                        if (matrix[row, col] == matrix[row + countX, col])
                        {
                            countX++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (maxCount < countX + 1)
                    {
                        maxCount = countX;
                        maxString = matrix[row, col];
                    }
                    while (col + countY < matrix.GetLength(1))
                    {
                        if (matrix[row, col] == matrix[row, col + countY])
                        {
                            countY++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (maxCount < countY + 1)
                    {
                        maxCount = countY;
                        maxString = matrix[row, col];
                    }
                    while (row + countX < matrix.GetLength(0) && col + countY < matrix.GetLength(1))
                    {
                        if (matrix[row,col] == matrix[row + countX, col + countX])
                        {
                            countX++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (maxCount < countX + 1)
                    {
                        maxCount = countX;
                        maxString = matrix[row, col];
                    }
                }
            }
            Console.WriteLine("Count: {0} String: {1}", maxCount, maxString);
        }
    }
}

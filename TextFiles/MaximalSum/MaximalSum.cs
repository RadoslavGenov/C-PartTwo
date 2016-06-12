namespace MaximalSum
{
    using System;
    using System.IO;

    class MaximalSum
    {
        public static int FindMaxArea(int[,] matrix)
        {
            int max = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int current = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (max < current)
                    {
                        max = current;
                    }
                }
            }
            return max;
        }

        public static int[,] ReadFile(string path)
        {
            int size;
            int[,] matrix;
            using (StreamReader reader = new StreamReader(path))
            {
                string allText = reader.ReadToEnd();
                string[] arrText = allText.Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
                size = int.Parse(arrText[0]);
                matrix = new int[size, size];
                int count = 1;
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        matrix[row, col] = int.Parse(arrText[count]);
                        count++;
                    }
                }
            }
            return matrix;
        }

        static void Main(string[] args)
        {
            var matrix = ReadFile(@"..\..\TextFile1.txt");
            int max = FindMaxArea(matrix);
            Console.WriteLine(max);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAreaInMatrix
{
    class LargestArea
    {
        static bool[,] visited = new bool[1000, 1000];
        static int[] dx = { -1, 1, 0, 0 };
        static int[] dy = { 0, 0, -1, 1 };
        static int newX;
        static int newY;
        static int DFS(int[,] graph, int x, int y, int value)
        {
            if (visited[x,y])
            {
                return 0;
            }
            else
            {
                visited[x, y] = true;
                int best = 0;
                int bestX = x, bestY = y;
                for (int i = 0; i < 4; i++)
                {
                    int modx = dx[i] + x;
                    int mody = dy[i] + x;

                    if (modx == -1 || modx >= graph.GetLength(0) ||
                        mody == -1 || mody >= graph.GetLength(1))
                    {
                        continue;
                    }
                    if (graph[modx, mody] == value)
                    {
                        int v = DFS(graph, modx, mody, graph[modx, mody]);
                        best += v;
                    }
                    newX = bestX;
                    newY = bestY;
                }
                return best + 1;
            }
        }
        static void Main(string[] args)
        {
            var matrix = new int[5, 6]
            {
                { 1, 3, 2, 2, 2, 4, },
                { 3, 3, 3, 2, 4, 4, },
                { 4, 3, 1, 2, 3, 3, },
                { 4, 3, 1, 3, 3, 1, },
                { 4, 3, 3, 3, 1, 1, }
            };

            int current = 0;
            int best = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (visited[i, k] == false)
                    {
                        current = DFS(matrix, i, k, matrix[i, k]);
                        if (best < current)
                        {
                            best = current;
                        }
                    }
                }
            }
            Console.WriteLine(best);
        }
    }
}

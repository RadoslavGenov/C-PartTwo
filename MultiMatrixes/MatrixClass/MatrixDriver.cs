using System;
using MatrixClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClass
{
    class MatrixDriver
    {
        static void Main(string[] args)
        {
            Matrix myMatrix = new Matrix(2, 3);
            Matrix myMatrix1 = new Matrix(3, 5);
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("matrix[{0}, {1}] = ", row, col);
                    myMatrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write("matrix[{0}, {1}] = ", row, col);
                    myMatrix1[row, col] = int.Parse(Console.ReadLine());
                }
            }
            
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(myMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //tests
            Matrix added = myMatrix + myMatrix;
            Matrix subtracted = myMatrix - myMatrix;
            Matrix multiplied = myMatrix * myMatrix1;
            
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(added[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(subtracted[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int row = 0; row < multiplied.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < multiplied.matrix.GetLength(1); col++)
                {
                    Console.Write(multiplied[row, col] + " ");
                }
                Console.WriteLine();
            }
           for (int row = 0; row < 2; row++)
           {
               for (int col = 0; col < 3; col++)
               {
                   Console.Write(myMatrix[row, col].ToString());
               }
               Console.WriteLine();
           }
        }
    }
}

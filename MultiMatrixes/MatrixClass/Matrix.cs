using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClass
{
    class Matrix
    {
        public int rows;
        public int cols;
        public int[,] matrix;
        public Matrix(int row, int col)
        {
            this.rows = row;
            this.cols = col;
            this.matrix = new int[rows, cols];
        }
        public int this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }
        public static Matrix operator +(Matrix matOne, Matrix matTwo)
        {
            Matrix result = new Matrix(matOne.rows, matTwo.cols);
            if (matOne.cols != matTwo.cols && matOne.rows != matTwo.rows)
            {
                throw new ArgumentException("The columns of the first are different from the rows of the second! ");
            }
            else
            {
                for (int row = 0; row < matOne.rows; row++)
                {
                    for (int col = 0; col < matTwo.cols; col++)
                    {
                        result.matrix[row, col] = matOne.matrix[row, col] + matTwo.matrix[row, col];
                    }
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix matOne, Matrix matTwo)
        {
            Matrix result = new Matrix(matOne.rows, matTwo.cols);
            if (matOne.cols != matTwo.cols && matOne.rows != matTwo.rows)
            {
                throw new ArgumentException("The columns of the first are different from the rows of the second! ");
            }
            else
            {
                for (int row = 0; row < matOne.rows; row++)
                {
                    for (int col = 0; col < matTwo.cols; col++)
                    {
                        result.matrix[row, col] = matOne.matrix[row, col] - matTwo.matrix[row, col];
                    }
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix matOne, Matrix matTwo)
        {
            Matrix result = new Matrix(matOne.rows, matTwo.cols);
            if (matOne.cols != matTwo.rows)
            {
                throw new ArgumentException("The columns of the first are different from the rows of the second! ");
            }
            else
            {
                for (int row = 0; row < matOne.matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matTwo.matrix.GetLength(1); col++)
                    {
                        for (int i = 0; i < matTwo.matrix.GetLength(0); i++)
                        {
                            result.matrix[row, col] += matOne.matrix[row, i] * matTwo.matrix[i, col];
                        }
                    }
                }
            }
            return result;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

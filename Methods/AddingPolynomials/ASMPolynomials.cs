using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class ASMPolynomials
    {
        static int[] Multiplication(int[] arrOne, int[] arrTwo)
        {
            var stack = new Stack<int>;
            int[] multiplication = new int[arrOne.Length + arrTwo.Length - 1];
            for (int i = 0; i < arrOne.Length; ++i)
            {
                for (int k = 0; k < arrTwo.Length; ++k)
                {
                    multiplication[i + k] += arrOne[i] * arrTwo[k];
                }
            }
            return multiplication;
        }
        static int[] Subtraction(int[] arrOne, int[] arrTwo)
        {
            int[] difference;
            if (arrOne.Length < arrTwo.Length)
            {
                difference = new int[arrTwo.Length];
                for (int i = arrTwo.Length - 1; i >= 0; --i)
                {
                    if (i > arrOne.Length - 1)
                    {
                        difference[i] = arrTwo[i];
                    }
                    else
                    {
                        difference[i] = arrOne[i] - arrTwo[i];
                    }
                }
            }
            else
            {
                difference = new int[arrOne.Length];
                for (int i = arrOne.Length - 1; i >= 0; --i)
                {
                    if (i > arrTwo.Length - 1)
                    {
                        difference[i] = arrOne[i];
                    }
                    else
                    {
                        difference[i] = arrOne[i] - arrTwo[i];
                    }
                }
            }
            return difference;
        }
        static int[] Addition(int[] arrOne, int[] arrTwo)
        {
            int[] sum;
            if (arrOne.Length < arrTwo.Length)
            {
                sum = new int[arrTwo.Length];
                for (int i = arrTwo.Length - 1; i >= 0; --i)
                {
                    if (i > arrOne.Length - 1)
                    {
                        sum[i] = arrTwo[i];
                    }
                    else
                    {
                        sum[i] = arrOne[i] + arrTwo[i];
                    }
                }
            }
            else
            {
                sum = new int[arrOne.Length];
                for (int i = arrOne.Length - 1; i >= 0; --i)
                {
                    if (i > arrTwo.Length - 1)
                    {
                        sum[i] = arrOne[i];
                    }
                    else
                    {
                        sum[i] = arrOne[i] + arrTwo[i];
                    }
                }
            }
            return sum;
        }
        static void PrintPolynomials(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; --i)
            {
                if (arr[i] == 0)
                {
                    continue;
                }
                else if (i == arr.Length - 1)
                {
                    Console.Write(" {0}X^{1}", arr[i], i);
                }
                else if (i == 0)
                {
                    if (arr[i] < 0)
                    {
                        Console.Write(" {0} {1}", '-', -arr[i]);
                    }
                    else
                    {
                        Console.Write(" {0} {1}", '+', arr[i]);
                    }
                }
                else
                {
                    if (arr[i] < 0)
                    {
                        Console.Write(" {0} {1}X^{2}", '-', -arr[i], i);
                    }
                    else
                    {
                        Console.Write(" {0} {1}X^{2}", '+', arr[i], i);
                    }
                }
            }
        }
        static int[] CreateArray()
        {
            Console.WriteLine("Enter degree of polynomial: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size + 1];

            for (int i = 0; i <= size; i++)
            {
                Console.Write("x^{0} = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] firstArr = CreateArray();
            int[] secondArr = CreateArray();

            PrintPolynomials(firstArr);
            Console.WriteLine();
            PrintPolynomials(secondArr);
            Console.WriteLine();

            Console.WriteLine("Addition : ");
            int[] sum = Addition(firstArr, secondArr);
            PrintPolynomials(sum);
            Console.WriteLine();

            Console.WriteLine("Subtraction : ");
            int[] subtraction = Subtraction(firstArr, secondArr);
            PrintPolynomials(subtraction);
            Console.WriteLine();

            Console.WriteLine("Multiplication : ");
            int[] multiplication = Multiplication(firstArr, secondArr);
            PrintPolynomials(multiplication);
            Console.WriteLine();

        }
    }
}

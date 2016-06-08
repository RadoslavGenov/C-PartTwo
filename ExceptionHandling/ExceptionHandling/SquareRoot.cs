using System;

namespace ExceptionHandling
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a positive number: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(Math.Sqrt(num));
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good-Bye");
            }

        }
    }
}

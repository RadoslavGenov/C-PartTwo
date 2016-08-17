namespace EnterNumbers
{
    using System;
    class EnterNumbers
    {
        private static int MIN = 1;
        private static int MAX = 100;
        public static void ReadNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number from {0}...{1}", MIN + 1, MAX - 1);
                int num = int.Parse(Console.ReadLine()); ;
                try
                {
                    if (num <= MIN || num >= MAX)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                MIN = num;
            }
        }
        static void Main(string[] args)
        {
            ReadNumber();
        }
    }
}

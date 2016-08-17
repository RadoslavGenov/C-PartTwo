namespace FormatNumbers
{
    using System;

    class FormatNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Decimal                  {0,15:0,000G}", number));
            Console.WriteLine(string.Format("Hexadecimal              {0,15:X}", number));
            Console.WriteLine(string.Format("Percent                  {0,15:P1}", number));
            Console.WriteLine(string.Format("Scientific Notation      {0,15:E2}", number));
        }
    }
}

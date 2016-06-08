namespace OrderWords
{
    using System;
    using System.Collections.Generic;
    class OrderWords
    {
        static void Main(string[] args)
        {
            var words = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            words.Sort();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}

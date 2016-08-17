namespace LetterCount
{
    using System;
    using System.Collections.Generic;

    class LetterCount
    {
        public static void Symbols(string input)
        {
            Dictionary<char, int> occurences = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!occurences.ContainsKey(input[i]))
                {
                    occurences.Add(input[i], 1);
                }
                else
                {
                    occurences[input[i]]++;
                }
            }
            foreach (var item in occurences)
            {
                Console.WriteLine("Symbol: {0} Occurences: {1}", item.Key, item.Value);
            }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Symbols(input);
        }
    }
}

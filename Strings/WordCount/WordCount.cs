using System;
using System.Collections.Generic;

namespace WordCount
{
    class WordCount
    {
        public static void Count(string input)
        {
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            string[] arr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr.Length; i++)
            {
                if (!occurences.ContainsKey(arr[i]))
                {
                    occurences.Add(arr[i], 1);
                }
                else
                {
                    occurences[arr[i]]++;
                }
            }
            foreach (var item in occurences)
            {
                Console.WriteLine("Word: {0} Occurences: {1}", item.Key, item.Value);
            }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Count(input);
        }
    }
}

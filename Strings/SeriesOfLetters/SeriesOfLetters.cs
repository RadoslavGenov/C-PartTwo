namespace SeriesOfLetters
{
    using System;
    using System.Text;
    class SeriesOfLetters
    {
        public static string Squeeze(string input)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                char temp = input[i - 1];
                if (input[i] != temp)
                {
                    builder.Append(input[i]);
                }
            }
            return builder.ToString();
        }
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            Console.WriteLine(Squeeze(series));
        }
    }
}

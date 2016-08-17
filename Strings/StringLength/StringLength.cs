namespace StringLength
{
    using System;
    using System.Text;
    class StringLength
    {
        public static string StringLengthStart(string input)
        {
            StringBuilder build = new StringBuilder(input);
            while (build.Length < 20)
            {
                build.Append("*");
            }
            return build.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string of no more than 20 characters: ");
            string input = Console.ReadLine();
            Console.WriteLine(StringLengthStart(input));
        }
    }
}

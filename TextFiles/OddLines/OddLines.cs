namespace Oddlines
{
    using System;
    using System.IO;

    class OddLines
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"..\..\TextFile1.txt"))
            {
                int count = 0;
                for (string read; (read = sr.ReadLine()) != null;)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(read);
                    }
                    count++;
                }
            }
        }
    }
}

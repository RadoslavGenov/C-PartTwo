namespace LineNumbers
{
    using System.IO;

    class LineNumbers
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"..\..\file1.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\file2.txt"))
                {
                    int count = 0;
                    for (string line; (line = reader.ReadLine()) != null;)
                    {
                        writer.WriteLine("{0} {1}", count, line);
                        count++;
                    }
                }
            }
        }
    }
}

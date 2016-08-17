using System;
using System.IO;

namespace CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            int equal = 0;
            int notEqual = 0;
            using (StreamReader fileOne = new StreamReader(@"..\..\textOne.txt"))
            {
                using (StreamReader fileTwo = new StreamReader(@"..\..\textTwo.txt"))
                {
                    while (!fileOne.EndOfStream)
                    {
                        string lineOne = fileOne.ReadLine();
                        string lineTwo = fileTwo.ReadLine();
                        if (lineOne != lineTwo)
                        {
                            notEqual++;
                        }
                        else
                        {
                            equal++;
                        }
                    }
                }
            }
            Console.WriteLine("Equal lines: {0}", equal);
            Console.WriteLine("Not equal lines: {0}", notEqual);
        }
    }
}

using System;
using System.IO;
using System.Text;

namespace ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            string path = @"..\..\TextFile3.txt";
            using (StreamReader sw1 = new StreamReader(@"..\..\TextFile1.txt"))
            {
                using (StreamReader sw2 = new StreamReader(@"..\..\TextFile2.txt"))
                {
                    string fileOne = sw1.ReadToEnd();
                    string fileTwo = sw2.ReadToEnd();
                    File.WriteAllText(path, fileOne + fileTwo);
                }
            }
        }
    }
}

namespace SaveSortedNames
{
    using System.IO;
    using System.Collections.Generic;

    class SaveSortedNames
    {
        public static void ReadAndSortFile(string path)
        {
            List<string> myList = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
                {
                    for (string line; (line = reader.ReadLine()) != null;)
                    {
                        myList.Add(line);
                    }
                    myList.Sort();
                    foreach (string line in myList)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            ReadAndSortFile(@"..\..\input.txt");
        }
    }
}

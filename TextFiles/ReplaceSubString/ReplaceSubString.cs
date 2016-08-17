namespace ReplaceSubString
{
    using System.IO;

    class ReplaceSubString
    {
        public static void ReplaceString(string path)
        {
            string replaced;
            using (StreamReader reader = new StreamReader(path))
            {
                string all = reader.ReadToEnd();
                replaced = all.Replace("start", "finish");
            }
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(replaced);
            }
        }

        static void Main(string[] args)
        {
            ReplaceString(@"..\..\TextFile1.txt");
        }
    }
}

namespace DownloadFile
{
    using System;
    using System.Net;
    using System.Reflection;

    class DownloadFile
    {
        static void Main(string[] args)
        {
            const string remoteUri = @"http://telerikacademy.com/Content/Images/news-img01.png";
            const string fileName = "news-img01.png";

            try
            {
                WebClient myWebClient = new WebClient();

                Console.WriteLine("Downloading file {0}", fileName);

                myWebClient.DownloadFile(remoteUri, fileName);

                Console.WriteLine("Succesfully downloaded {0} from {1}", fileName, remoteUri);
                Console.WriteLine("Downloaded to {0}", Assembly.GetExecutingAssembly().Location);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(WebException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good-Bye");
            }
        }
    }
}

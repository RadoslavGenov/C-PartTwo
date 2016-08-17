namespace BulgarianDate
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Text;

    class BulgarianDate
    {
        public static string BGTime(string time)
        {
            DateTime bgTime = DateTime.ParseExact(time, "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture);
            DateTime addedHours = bgTime.AddHours(6.5);
            return addedHours.ToString("dd.MM.yyyy H:mm:ss dddd");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            string time = Console.ReadLine();
            Console.WriteLine(BGTime(time));
        }
    }
}

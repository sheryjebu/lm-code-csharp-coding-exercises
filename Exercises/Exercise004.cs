using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            const long giga_sec = 1000000000;
            System.Console.WriteLine(dateTime.AddSeconds(giga_sec));

            return dateTime.AddSeconds(giga_sec);

        }
    }
}

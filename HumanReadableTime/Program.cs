//Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM: SS)

//HH = hours, padded to 2 digits, range: 00 - 99
//MM = minutes, padded to 2 digits, range: 00 - 59
//SS = seconds, padded to 2 digits, range: 00 - 59
//The maximum time never exceeds 359999 (99:59:59)

//You can find some examples in the test fixtures.

using System;

namespace HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            Console.WriteLine(TimeFormat.GetReadableTimeSimple(Int32.Parse(line)));
            Console.ReadKey();
        }
    }
    public static class TimeFormat
    {
        public static string GetReadableTimeSimple(int seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            string result = string.Format("{0:00}:{1:00}:{2:00}",t.TotalHours, t.Minutes, t.Seconds);
            return result;
        }
        public static string GetReadableTimeBad(int seconds)
        {
            string result = string.Empty;
            int sec = 0;
            int min = 0;
            int hours = 0;

            hours = seconds / 3600;
            if (hours > 0)
                if (hours > 9)
                    result += $"{hours}:";
                else
                    result += $"0{hours}:";
            else
                result += $"00:";
            min = (seconds % 3600) / 60;
            if (min > 0)
                if (min > 9)
                    result += $"{min}:";
                else
                    result += $"0{min}:";
            else
                result += $"00:";

            sec = (seconds % 3600) % 60;
            if (sec > 0)
                if (sec > 9)
                    result += $"{sec}";
                else
                    result += $"0{sec}";
            else
                result += $"00";
            return result;
        }
    }
}

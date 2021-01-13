//Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM: SS)

//HH = hours, padded to 2 digits, range: 00 - 99
//MM = minutes, padded to 2 digits, range: 00 - 59
//SS = seconds, padded to 2 digits, range: 00 - 59
//The maximum time never exceeds 359999 (99:59:59)

//You can find some examples in the test fixtures.

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            //line = line.Remove(1, line.Length - 2).Remove(-1);
            //foreach(var a in GenerateRange(2, 100, 4))
            Console.WriteLine(SuperSize(long.Parse(line)));
            Console.ReadKey();
        }
        public static int FindSmallestInt(int[] args) => args.Sum(i => i * i);
        public static int CountSheeps(bool[] sheeps) => sheeps.Sum(i => i ? 1 : 0);
        public static int CountSheepsN(bool[] sheeps) => sheeps.Count(s => s);
        public static int[] GenerateRange(int min, int max, int step)
        {
            // your code goes here
            List<int> a = new List<int>();
            a.Add(min);
            int i = min;
            while (i < max)
            {
                i = min + step;
                if (i < max)
                    a.Add(i);
            }
            a.Add(max);
            return a.ToArray();
        }
        public static long SuperSize(long num)
        {
            var a = string.Empty;
            foreach (var b in num.ToString().ToList().OrderByDescending(x => x).ToList())
                a += b;
            return long.Parse(a);
        }
    }


    public static class Kata
    {
        public static string Performance(Func<int> method)
        {
            StringBuilder sb1 = new StringBuilder();
            for (int i = 0; i < 150000; i++)
            {
                sb1.Append(method().ToString());
            }
            return sb1.ToString();
        }
    }
    //public static class TimeFormat
    //{
    //    public static string GetReadableTimeSimple(int seconds)
    //    {
    //        TimeSpan t = TimeSpan.FromSeconds(seconds);
    //        string result = string.Format("{0:00}:{1:00}:{2:00}", t.TotalHours, t.Minutes, t.Seconds);
    //        return result;
    //        double a = 2.5;
    //        int()System.Math.Round(a / 0.5, MidpointRounding.AwayFromZero);
    //    }
    //    public static string AbbrevName(string name)
    //    {
    //        var arr = name.ToUpper().Split(" ");
    //        return arr[0][0] + "." + arr[1][0];
    //    }
    //    public static int[] Maps(int[] x)
    //    {
    //        for (int i = 0; i < x.Length; i++)
    //            x[i] = x[i] * 2;

    //        x.ToList().ForEach(y => y * 2);
    //        return x;
    //    }

    //    public static int GetVowelCount(string str)
    //    {
    //        int vowelCount = 0;

    //        string vowels = "aeiou";
    //        foreach (var c in str)
    //            if (vowels.Contains(c))
    //                vowelCount++;

    //        return str.Count(i => "aeiou".Contains(i));
    //    }

    //    public static string GetMiddle(string s)
    //    {
    //        if (s.Length % 2 == 0)
    //            return s.Substring((s.Length / 2 - 1), 2);
    //        else
    //            return s.Substring((s.Length / 2 - 1), 1);
    //    }
    //    public static int[] CountPositivesSumNegatives(int[] input)
    //    {
    //        if (!input.Any())
    //            return new int[] { input.Count(x => x > 0), input.Where(x => x < 0).Sum() };
    //        else
    //            return new int[] { };
    //    }
    //    public static bool ArrayMadness(int[] a, int[] b)
    //    {
    //        return a.Sum() > b.Sum() ? true : false;
    //    }
    //    public static long[] Digitize(long n)
    //    {
    //        long[] l = n.ToString().ToArray().Reverse().Select(d => long.Parse(d.ToString())).ToArray();

    //    }
    //    public static string GetReadableTimeBad(int seconds)
    //    {
    //        string result = string.Empty;
    //        int sec = 0;
    //        int min = 0;
    //        int hours = 0;

    //        hours = seconds / 3600;
    //        if (hours > 0)
    //            if (hours > 9)
    //                result += $"{hours}:";
    //            else
    //                result += $"0{hours}:";
    //        else
    //            result += $"00:";
    //        min = (seconds % 3600) / 60;
    //        if (min > 0)
    //            if (min > 9)
    //                result += $"{min}:";
    //            else
    //                result += $"0{min}:";
    //        else
    //            result += $"00:";

    //        sec = (seconds % 3600) % 60;
    //        if (sec > 0)
    //            if (sec > 9)
    //                result += $"{sec}";
    //            else
    //                result += $"0{sec}";
    //        else
    //            result += $"00";
    //        return result;
    //    }
    //}
}

using System;
using System.Linq;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //foreach (var word in @"noget text and stuff,,,,.....????QW""##?¤#""?¤?""#?¤#""¤?#""¤?""#åøæå".Split(@"\P{L}+"))
            //{
            //    Console.WriteLine(word);
            //}

            var ys = new[] { 1, 2, 3, 4, 70, 2000, 1700, 1800, 1900, 1600 };

            //var yss = from y in ys
            //          where y > 42 && y % 7 == 0
            //          select y;
            int Year = 0;

            var yss = from y in ys
                      where DateTime.IsLeapYear(y)
                      select y;

            //var yss = ys.Where(y => y > 42 && y % 7 == 0);

            foreach (var item in yss)
            {
                Console.WriteLine(item);
            }
        }
    }
}

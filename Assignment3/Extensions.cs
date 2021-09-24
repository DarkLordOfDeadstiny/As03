using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2021.Assignment03
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri uri)
        {
            return uri.Scheme == Uri.UriSchemeHttps;
        }

        public static int WordCount(this string s)
        {
            return Regex.Split(s, @"\P{L}+").Length;
        }


    }
}

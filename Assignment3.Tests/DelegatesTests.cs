using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;
using System.IO;

namespace BDSA2021.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void reversed_numbers_in_string()
        {
            var writter = new StringWriter();
            Console.SetOut(writter);

            var input = "1 2 3 4 5 6 7 8 9";

            var reverse = (string s) => Console.WriteLine(String.Concat(s.Reverse()));
            reverse(input);

            var expected = "9 8 7 6 5 4 3 2 1";

            Assert.Equal(expected.ToCharArray(), writter.GetStringBuilder().ToString().Trim());
        }

        [Fact]
        public void find_product_of_two_numbers()
        {
            var product = (decimal d1, decimal d2) => d1 * d2;

            Assert.Equal(10, product(2, 5));
        }

        [Fact]
        public void true_string_is_equal_to_int()
        {
            var s = " ,. 0042";
            var num = 0042;

            var isEqual = (string s, int num) => int.Parse(s.Trim(' ',',','.')) == num;

            Assert.True(isEqual(s, num));
        }




    }
}

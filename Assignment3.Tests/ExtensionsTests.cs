using System;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Uri_is_HTTPS()
        {
            var uri = new Uri("https://github.itu.dk/BDSA2021/Assignment3");

            Assert.True(Extensions.IsSecure(uri));
        }

        [Fact]
        public void Uri_is_not_HTTPS()
        {
            var uri = new Uri("http://github.itu.dk/BDSA2021/Assignment3");

            Assert.False(uri.IsSecure());
        }

        [Fact]
        public void WordCount()
        {
            var indput = @"noget text and stuff,,,,.....????QW""##?¤#""?¤?""#?¤#""¤?#""¤?""#åøæå";

            Assert.Equal(6, indput.WordCount());
        }
    }
}

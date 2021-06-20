using System;
using Xunit;

namespace RLE.CSharp.Tests
{
    public class EncoderTests
    {
        [Fact]
        public void Can_encode_single_letter() => 
            Assert.Equal("1a", Encoder.Process("a"));

        [Fact]
        public void Can_encode_single_letter_group() => 
            Assert.Equal("5a", Encoder.Process("aaaaa"));

        [Fact]
        public void Can_encode_multiple_letter_group1() => 
            Assert.Equal("3c5a2d4t", Encoder.Process("cccaaaaaddtttt"));

        [Fact]
        public void Can_encode_multiple_letter_group2() => 
            Assert.Equal("1x1y1z3c5a2d4t3a4b1a1b1a1b", Encoder.Process("xyzcccaaaaaddttttaaabbbbabab"));
    }
}

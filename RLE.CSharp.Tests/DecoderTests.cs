using Xunit;

namespace RLE.CSharp.Tests
{
    public class DecoderTests
    {
        [Fact]
        public void Can_decode_single_tuple() => 
            Assert.Equal("a", Decoder.Process("1a"));

        [Fact]
        public void Can_decode_single_tuple_multiple_chars() => 
            Assert.Equal("aaa", Decoder.Process("3a"));

        [Fact]
        public void Can_decode_multiple_tuple_single_chars() => 
            Assert.Equal("abc", Decoder.Process("1a1b1c"));

        [Fact]
        public void Can_decode_multiple_tuple_multiple_chars() => 
            Assert.Equal("aabbbc", Decoder.Process("2a3b1c"));

        [Fact]
        public void Can_decode_multiple_tuple_multiple_chars_with_repeats() => 
            Assert.Equal("aabbbcaaaaxbbbbbcc", Decoder.Process("2a3b1c4a1x5b2c"));
    }
}

using System;
using Xunit;

namespace RomanNumerals.Logic.Tests
{
    #pragma warning disable xUnit1004 // Test methods should not be skipped
    public class CodewarsRomanNumeralsTest
    {
        [Fact]
        public void TestToRoman_001()
        {
            int input = 1;
            string expected = "I";

            string actual = RomanNumerals.ToRoman(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestToRoman_002()
        {
            int input = 2;
            string expected = "II";

            string actual = RomanNumerals.ToRoman(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFromRoman_001()
        {
            string input = "I";
            int expected = 1;

            int actual = RomanNumerals.FromRoman(input);

            Assert.Equal(expected, actual);
        }

        [Fact(Skip="Not implemented yet")]
        public void TestFromRoman_002()
        {
            string input = "II";
            int expected = 2;

            int actual = RomanNumerals.FromRoman(input);

            Assert.Equal(expected, actual);
        }
    }
}

using Xunit;

namespace RomanNumerals.Logic.Tests
{
    public class RomanNumeralsTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        public void ToRoman_SingleNumeralResult_MatchesExpectation(int input, string expected)
        {
            Assert.Equal(expected, RomanNumerals.ToRoman(input));
        }

        [Theory]
        [InlineData(2, "II")]
//        [InlineData(20, "XX")]
        public void ToRoman_TwoIdenticalNumeralsResult_MatchesExpectation(int input, string expected)
        {
            Assert.Equal(expected, RomanNumerals.ToRoman(input));
        }
    }
}
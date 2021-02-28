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
        [InlineData(20, "XX")]
        [InlineData(200, "CC")]
        [InlineData(2000, "MM")]

        [InlineData(3, "III")]
        [InlineData(30, "XXX")]
        [InlineData(300, "CCC")]
        [InlineData(3000, "MMM")]

        [InlineData(4000, "MMMM")]

        [InlineData(6, "VI")]
        [InlineData(1666, "MDCLXVI")]
        public void ToRoman_SimpleMultipleNumeralsResult_MatchesExpectation(int input, string expected)
        {
            Assert.Equal(expected, RomanNumerals.ToRoman(input));
        }

        [Theory]
        [InlineData(4, "IV")]
        [InlineData(9, "IX")]
        [InlineData(40, "XL")]
        [InlineData(90, "XC")]
        [InlineData(400, "CD")]
        [InlineData(900, "CM")]
        public void ToRoman_NextMinusPrevious_MatchesExpectation(int input, string expected)
        {
            Assert.Equal(expected, RomanNumerals.ToRoman(input));
        }
    }
}
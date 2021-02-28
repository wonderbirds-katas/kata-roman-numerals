using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals.Logic
{
    public class RomanNumerals
    {
        public static string ToRoman(int input)
        {
            var mapNumberToRoman = new Dictionary<int, string> {
                { 1, "I" },
                { 4, "IV" },
                { 5, "V" },
                { 9, "IX" },
                { 10, "X" },
                { 40, "XL" },
                { 50, "L" },
                { 90, "XC" },
                { 100, "C" },
                { 400, "CD" },
                { 500, "D" },
                { 900, "CM" },
                { 1000, "M" },
            };

            var remainder = input;
            var output = new StringBuilder();

            foreach(var numberToRoman in mapNumberToRoman.Reverse())
            {
                while (remainder >= numberToRoman.Key)
                {
                    remainder -= numberToRoman.Key;
                    output.Append(numberToRoman.Value);
                }
            }

            return output.ToString();
        }

        public static int FromRoman(string input) => 1;
    }
}

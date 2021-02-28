using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals.Logic
{
    public class RomanNumerals
    {
        public static string ToRoman(int input)
        {
            var mapNumberToRoman = new Dictionary<int, string> {
                { 1, "I" },
                { 5, "V" },
                { 10, "X" },
                { 50, "L" },
                { 100, "C" },
                { 500, "D" },
                { 1000, "M" },
            };

            var remainder = input;
            var output = new StringBuilder();
            while (remainder > 0)
            {
                if (mapNumberToRoman.ContainsKey(remainder))
                {
                    output.Append(mapNumberToRoman[remainder]);
                    remainder -= remainder;
                }
                else
                {
                    output.Append('I');
                    remainder -= 1;
                }
            }
            return output.ToString();
        }

        public static int FromRoman(string input) => 1;
    }
}

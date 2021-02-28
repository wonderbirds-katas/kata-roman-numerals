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
                { 5, "V" },
                { 10, "X" },
                { 50, "L" },
                { 100, "C" },
                { 500, "D" },
                { 1000, "M" },
            };

            var remainder = input;
            var output = new StringBuilder();

            foreach(var numberToRoman in mapNumberToRoman.Reverse())
            {
                if (remainder >= numberToRoman.Key)
                {
                    remainder -= numberToRoman.Key;
                    output.Append(numberToRoman.Value);
                }
            }

            while (remainder > 0)
            {
                remainder -= 1;
                output.Append('I');
            }

            return output.ToString();
        }

        public static int FromRoman(string input) => 1;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals.Logic
{
    public class RomanNumerals
    {
        private static Dictionary<int, string> _mapNumberToRoman = new() {
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

        public static string ToRoman(int input)
        {
            var remainder = input;
            var output = new StringBuilder();

            foreach(var numberToRoman in _mapNumberToRoman.Reverse())
            {
                while (remainder >= numberToRoman.Key)
                {
                    remainder -= numberToRoman.Key;
                    output.Append(numberToRoman.Value);
                }
            }

            return output.ToString();
        }

        public static int FromRoman(string input) 
        {
            var mapRomanToNumber = _mapNumberToRoman.ToDictionary(t => t.Value, t => t.Key);

            var remainder = input.ToList();
            var output = 0;

            foreach(var romanLetter in input.Reverse())
            {
                output += mapRomanToNumber[romanLetter.ToString()];
            }

            return output;
        }
    }
}

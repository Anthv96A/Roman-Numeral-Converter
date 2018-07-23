using RomanNumeralConverter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConverter.Services
{
    public class NumberDictionary : INumberDictionary
    {
        public IDictionary<int, string> NumbersAndCharacters()
        {
            return new Dictionary<int, string>()
            {
                { 100 , "C"},
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X"},
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };
        }
    }
}

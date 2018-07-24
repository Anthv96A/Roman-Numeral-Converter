
using RomanNumeralConverter.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralConverter.Services
{
    public class ConvertRomanNumeral : IConvertRomanNumeral
    {

       private IDictionary<int, string> numbers = new Dictionary<int, string>()
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

        public string ConvertNumberToNumeral(int input)
        {
            string romanNum = "";

            foreach (var item in numbers)
            {
                if (input >= item.Key)
                {
                    input -= item.Key;
                    romanNum += item.Value;
                    return romanNum + ConvertNumberToNumeral(input);
                }
            }
            return romanNum;
        }
    }
}

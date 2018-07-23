
using RomanNumeralConverter.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralConverter.Services
{
    public class ConvertRomanNumeral : IConvertRomanNumeral
    {
        private readonly IComputeValue iComputeValue;

        public ConvertRomanNumeral(IComputeValue iComputeValue)
        {
            this.iComputeValue = iComputeValue;
        }

        public string ConvertNumberToNumeral(int input)
        {
            return iComputeValue.Compute(input);
        }
    }
}

using RomanNumeralConverter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace RomanNumeralConverter.Services
{
    public class ComputeValue : IComputeValue
    {
        private readonly INumberDictionary numberDictionary;

        public ComputeValue(INumberDictionary numberDictionary)
        {
            this.numberDictionary = numberDictionary;
        }

        public string Compute(int number)
        {
            string romanNum = "";

            IDictionary<int, string> numbers = numberDictionary.NumbersAndCharacters();

             foreach (var item in numbers)
             {

               if(number >= item.Key)
               {
                 number -= item.Key;
                 romanNum += item.Value;
                 return romanNum + Compute(number);
               }
             }
            return romanNum;
        }
    }
}

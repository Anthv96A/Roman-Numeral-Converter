using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConverter.Interfaces
{
    public interface INumberDictionary
    {
        IDictionary<int, string> NumbersAndCharacters();
    }
}

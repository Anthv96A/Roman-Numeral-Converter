using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralConverter.Interfaces;
using RomanNumeralConverter.Services;


namespace RomanNumeralConverter.Tests
{
    [TestClass]
    public class NumberConverter_Tests
    {
        [TestMethod]
        public void Given_I_Pass_The_Value_1_I_Should_Expect_The_Value_I_Returned()
        {
            // Given I have a value of 1
            var input = 1;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "I"
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_2_I_Should_Expect_The_Value_II_Returned()
        {
            // Given I have a value of 2
            var input = 2;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "II"
            Assert.AreEqual("II", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_3_I_Should_Expect_The_Value_III_Returned()
        {
            // Given I have a value of 3
            var input = 3;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "III"
            Assert.AreEqual("III", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_4_I_Should_Expect_The_Value_IV_Returned()
        {
            // Given I have a value of 4
            var input = 4;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "IV"
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_5_I_Should_Expect_The_Value_V_Returned()
        {
            // Given I have a value of 5
            var input = 5;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "V"
            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_6_I_Should_Expect_The_Value_VI_Returned()
        {
            // Given I have a value of 6
            var input = 6;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "VI"
            Assert.AreEqual("VI", result);
        }


        [TestMethod]
        public void Given_I_Pass_The_Value_7_I_Should_Expect_The_Value_VII_Returned()
        {
            // Given I have a value of 7
            var input = 7;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "VII"
            Assert.AreEqual("VII", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_8_I_Should_Expect_The_Value_VIII_Returned()
        {
            // Given I have a value of 8
            var input = 8;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "VIII"
            Assert.AreEqual("VIII", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_9_I_Should_Expect_The_Value_IX_Returned()
        {
            // Given I have a value of 9
            var input = 9;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "IX"
            Assert.AreEqual("IX", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_10_I_Should_Expect_The_Value_X_Returned()
        {
            // Given I have a value of 10
            var input = 10;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "X"
            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_11_I_Should_Expect_The_Value_XI_Returned()
        {
            // Given I have a value of 11
            var input = 11;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XI"
            Assert.AreEqual("XI", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_12_I_Should_Expect_The_Value_XII_Returned()
        {
            // Given I have a value of 12
            var input = 12;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XII"
            Assert.AreEqual("XII", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_14_I_Should_Expect_The_Value_XIV_Returned()
        {
            // Given I have a value of 14
            var input = 14;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XIV"
            Assert.AreEqual("XIV", result);
        }


        [TestMethod]
        public void Given_I_Pass_The_Value_15_I_Should_Expect_The_Value_XV_Returned()
        {
            // Given I have a value of 15
            var input = 15;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XV"
            Assert.AreEqual("XV", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_19_I_Should_Expect_The_Value_XIX_Returned()
        {
            // Given I have a value of 19
            var input = 19;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XIX"
            Assert.AreEqual("XIX", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_20_I_Should_Expect_The_Value_XX_Returned()
        {
            // Given I have a value of 20
            var input = 20;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XX"
            Assert.AreEqual("XX", result);
        }


        [TestMethod]
        public void Given_I_Pass_The_Value_24_I_Should_Expect_The_Value_XXIV_Returned()
        {
            // Given I have a value of 24
            var input = 24;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XXIV"
            Assert.AreEqual("XXIV", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_29_I_Should_Expect_The_Value_XXIX_Returned()
        {
            // Given I have a value of 29
            var input = 29;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XXIX"
            Assert.AreEqual("XXIX", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_30_I_Should_Expect_The_Value_XXX_Returned()
        {
            // Given I have a value of 30
            var input = 30;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XXX"
            Assert.AreEqual("XXX", result);
        }


        [TestMethod]
        public void Given_I_Pass_The_Value_35_I_Should_Expect_The_Value_XXXV_Returned()
        {
            // Given I have a value of 35
            var input = 35;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XXXV"
            Assert.AreEqual("XXXV", result);
        }


        [TestMethod]
        public void Given_I_Pass_The_Value_39_I_Should_Expect_The_Value_XXXIX_Returned()
        {
            // Given I have a value of 39
            var input = 39;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XXXIX"
            Assert.AreEqual("XXXIX", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_40_I_Should_Expect_The_Value_XL_Returned()
        {
            // Given I have a value of 40
            var input = 40;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XL"
            Assert.AreEqual("XL", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_41_I_Should_Expect_The_Value_XLI_Returned()
        {
            // Given I have a value of 41
            var input = 41;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XLI"
            Assert.AreEqual("XLI", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_44_I_Should_Expect_The_Value_XLIV_Returned()
        {
            // Given I have a value of 44
            var input = 44;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XLIV"
            Assert.AreEqual("XLIV", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_50_I_Should_Expect_The_Value_L_Returned()
        {
            // Given I have a value of 50
            var input = 50;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "L"
            Assert.AreEqual("L", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_60_I_Should_Expect_The_Value_LX_Returned()
        {
            // Given I have a value of 60
            var input = 60;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "LX"
            Assert.AreEqual("LX", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_70_I_Should_Expect_The_Value_LXX_Returned()
        {
            // Given I have a value of 70
            var input = 70;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "LXX"
            Assert.AreEqual("LXX", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_90_I_Should_Expect_The_Value_XC_Returned()
        {
            // Given I have a value of 90
            var input = 90;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "XC"
            Assert.AreEqual("XC", result);
        }

        [TestMethod]
        public void Given_I_Pass_The_Value_100_I_Should_Expect_The_Value_C_Returned()
        {
            // Given I have a value of 100
            var input = 100;

            // When I pass the value into the Roman Numeral converter
            IConvertRomanNumeral convertRomanNumeral = new ConvertRomanNumeral(new ComputeValue(new NumberDictionary()));
            string result = convertRomanNumeral.ConvertNumberToNumeral(input);

            // Then I expect the value returned is "C"
            Assert.AreEqual("C", result);
        }



    }
}

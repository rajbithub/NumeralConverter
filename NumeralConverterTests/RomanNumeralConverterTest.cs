using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeralConverter;

namespace NumeralConverterTests
{
    [TestClass]
    public class RomanNumeralConverterTests
    {
        [TestMethod]
        public void TestConvertThousandNineHundred()
        {
            var expected = "MCMIII";
            var input = 1903;

            var actual = RomanNumeralConverter.ConvertIntToRoman(input);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestConvertThousandFiveHundred()
        {
            var expected = "MDLV";
            var input = 1555;

            var actual = RomanNumeralConverter.ConvertIntToRoman(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestConvertFourHundred()
        {
            var expected = "MCDXLIV";
            var input = 1444;

            var actual = RomanNumeralConverter.ConvertIntToRoman(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestConvertThousands()
        {
            var expected = "MMMCCXII";
            var input = 3212;

            var actual = RomanNumeralConverter.ConvertIntToRoman(input);

            Assert.AreEqual(expected, actual);
        }

    }
}

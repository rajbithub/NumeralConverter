using System.Text;

namespace NumeralConverter
{
    public static class RomanNumeralConverter
    {
        public static string ConvertIntToRoman(int number)
        {
            var romanNumeral = new StringBuilder();
            string[] romanSymbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] mappedIntegers = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            for (int position = 0; number > 0; position++)
            {
                int repeatCount = number / mappedIntegers[position];
                for (int i = 0; i < repeatCount; i++)
                {
                    romanNumeral.Append(romanSymbols[position]);
                }
                number %= mappedIntegers[position];
            }
            return romanNumeral.ToString();
        }
    }
}

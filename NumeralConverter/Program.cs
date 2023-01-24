using System;

namespace NumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to convert to Roman numeral: ");
            var input = Console.ReadLine();
            var number = 0;
            Int32.TryParse(input, out number);

            Console.WriteLine($"Converted {number} to  Roman as {RomanNumeralConverter.ConvertIntToRoman(number)} ");

            Console.WriteLine("Click any key to exit.. ");
            Console.ReadLine();
        }
    }
}

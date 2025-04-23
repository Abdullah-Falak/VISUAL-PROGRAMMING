using System;

namespace MinMaxExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Min and Max for int
            int minInt = int.MinValue; // Minimum int value
            int maxInt = int.MaxValue; // Maximum int value

            // Min and Max for long
            long minLong = long.MinValue; // Minimum long value
            long maxLong = long.MaxValue; // Maximum long value

            double minDouble = double.MinValue;
            double maxDouble = double.MaxValue;

            string str1 = "Apple";
            string str2 = "Banana";
            string minString = (string.Compare(str1, str2) < 0) ? str1 : str2;
            string maxString = (string.Compare(str1, str2) > 0) ? str1 : str2;

            Console.WriteLine("Int Min: " + minInt);
            Console.WriteLine("Int Max: " + maxInt);

            Console.WriteLine("Long Min: " + minLong);
            Console.WriteLine("Long Max: " + maxLong);

            Console.WriteLine("Double Min: " + minDouble);
            Console.WriteLine("Double Max: " + maxDouble);

            Console.WriteLine("Min String: " + minString);
            Console.WriteLine("Max String: " + maxString);
        }
    }
}

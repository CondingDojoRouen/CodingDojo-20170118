using System;

namespace CodingDojo
{
    public static class KataRomanCalculator
    {
        public static string Add(string n1, string n2)
        {
            if (string.IsNullOrWhiteSpace(n1))
                return n2;
            
            Enum.TryParse<RomanFormat>(n1, out var numeric1);
            Enum.TryParse<RomanFormat>(n2, out var numeric2);

            int numericResult = (int)numeric1 + (int)numeric2;

            string result = Enum.GetName(typeof(RomanFormat), numericResult);

            return result;
        }
    }

    public enum RomanFormat
    {
        I = 1,
        II = 2,
        III = 3,
        IV = 4,
        VII = 7,
        IX = 9,
    }
}

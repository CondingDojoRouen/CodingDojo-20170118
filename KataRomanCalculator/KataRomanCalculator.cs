using System;
using System.Linq;

namespace CodingDojo
{
    public static class KataRomanCalculator
    {
        public static string Add(string n1, string n2)
        {
            if (string.IsNullOrWhiteSpace(n1))
                return n2;

            int numericResult = Compute(n1) + Compute(n2);

            string result = Enum.GetName(typeof(RomanFormat), numericResult);

            return result;
        }
        public static int Compute(string roman)
        {
            int result;

            result = roman.Reverse().Select(c => {
                Enum.TryParse<RomanFormat>(c.ToString(), out var numeric);
                return (int)numeric;
            }).Aggregate(new Tuple<int, int>(0, 0),
                        (acc, currentInt) => currentInt < acc.Item2 ? new Tuple<int, int>(acc.Item1 - currentInt, currentInt)
                                                                    : new Tuple<int, int>(acc.Item1 + currentInt, currentInt),
                        t => t.Item1);

            return result;
        }
    }

    

    public enum RomanFormat
    {
        I = 1,
        II = 2,
        III = 3,
        IV = 4,
        V = 5,
        VII = 7,
        IX = 9,
        X = 10,
        L = 50
    }
}

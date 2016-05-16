using System;
using System.Collections.Generic;
using System.Linq;

public class OneSystem2AnyOther
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        string number = (Console.ReadLine()).ToUpper();
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine(DecimalToArbitrarySystem(ArbitraryToDecimalSystem(number, s), d));
    }
    public static long ArbitraryToDecimalSystem(string number, int baseS)
    {
        const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        if (baseS < 2 || baseS > digits.Length)
            throw new ArgumentException("The radix must be >= 2 and <= " +
                digits.Length.ToString());

        if (String.IsNullOrEmpty(number))
            return 0;

        number = number.ToUpperInvariant();

        long result = 0;
        long multiplier = 1;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            char c = number[i];
            if (i == 0 && c == '-')
            {
                // This is the negative sign symbol
                result = -result;
                break;
            }

            int digit = digits.IndexOf(c);
            if (digit == -1)
                throw new ArgumentException(
                    "Invalid character in the arbitrary numeral system number",
                    "number");

            result += digit * multiplier;
            multiplier *= baseS;
        }

        return result;
    }
    public static string DecimalToArbitrarySystem(long decimalNumber, int baseD)
    {
        const int bitsInLong = 64;
        const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        if (baseD < 2 || baseD > digits.Length)
            throw new ArgumentException("The radix must be >= 2 and <= " + digits.Length.ToString());

        if (decimalNumber == 0)
            return "0";

        int index = bitsInLong - 1;
        long currentNum = Math.Abs(decimalNumber);
        char[] charArr = new char[bitsInLong];

        while (currentNum != 0)
        {
            int remainder = (int)(currentNum % baseD);
            charArr[index--] = digits[remainder];
            currentNum = currentNum / baseD;
        }

        string result = new String(charArr, index + 1, bitsInLong - index - 1);
        if (decimalNumber < 0)
        {
            result = "-" + result;
        }

        return result;
    }
}
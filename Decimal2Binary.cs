namespace Decimal_To_Binary
{
    using System;

    public class Decimal2Binary
    {
        static string DecimalToBinary(long number)
        {
            string binaryNum = string.Empty;
            string reversed = string.Empty;

            if (number == 0)
            {
                return binaryNum += 0;
            }
            while (number > 0)
            {
                reversed += number % 2;
                number /= 2;
            }

            for (int i = reversed.Length - 1; i >= 0; i--)
            {
                binaryNum += reversed[i];
            }
            return binaryNum;
        }

        static void Main()
        {
            long inputNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(inputNumber));
        }
    }
}
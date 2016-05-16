namespace Decimal_To_Hexadecimal
{
    using System;

    public class Decimal2Hexadecimal
    {
        static string DecimalToHex(long decNum)
        {
            string hexNum = string.Empty;

            if (decNum == 0)
            {
                return hexNum += 0;
            }
            while (decNum > 0)
            {
                switch (decNum % 16)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9: hexNum = decNum % 16 + hexNum; break;
                    case 10: hexNum = "A" + hexNum; break;
                    case 11: hexNum = "B" + hexNum; break;
                    case 12: hexNum = "C" + hexNum; break;
                    case 13: hexNum = "D" + hexNum; break;
                    case 14: hexNum = "E" + hexNum; break;
                    case 15: hexNum = "F" + hexNum; break;
                }
                decNum /= 16;
            }

            return hexNum;
        }
        static void Main()
        {
            long decimalN = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHex(decimalN));
        }
    }
}
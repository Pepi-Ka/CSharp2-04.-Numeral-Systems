namespace HexaDecimal_To_Decimal
{
    using System;

    public class Hexadecimal2Decimal
    {
        public static long HexToDecimal(string number)
        {
            long decNum = 0;
            int position = number.Length - 1;

            foreach (var n in number)
            {
                switch (n)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9': decNum += (long)Math.Pow(16, position) * (n - 48); break;
                    case 'A': decNum += (long)Math.Pow(16, position) * 10; break;
                    case 'B': decNum += (long)Math.Pow(16, position) * 11; break;
                    case 'C': decNum += (long)Math.Pow(16, position) * 12; break;
                    case 'D': decNum += (long)Math.Pow(16, position) * 13; break;
                    case 'E': decNum += (long)Math.Pow(16, position) * 14; break;
                    case 'F': decNum += (long)Math.Pow(16, position) * 15; break;
                }
                position--;
            }
            return decNum;
        }
        static void Main()
        {
            string inputNumber = Console.ReadLine();
            Console.WriteLine(HexToDecimal(inputNumber));
        }
    }
}
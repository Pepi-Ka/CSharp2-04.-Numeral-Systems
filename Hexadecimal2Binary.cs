namespace HexaDecimal_To_Binary
{
    using System;

    public class Hexadecimal2Binary
    {
        public static string HexadecimalToBinary(string hexNum)
        {
            string binaryNum = string.Empty;

            foreach (var n in hexNum)
            {
                switch (n)
                {
                    case '0': binaryNum += "0000"; break;
                    case '1': binaryNum += "0001"; break;
                    case '2': binaryNum += "0010"; break;
                    case '3': binaryNum += "0011"; break;
                    case '4': binaryNum += "0100"; break;
                    case '5': binaryNum += "0101"; break;
                    case '6': binaryNum += "0110"; break;
                    case '7': binaryNum += "0111"; break;
                    case '8': binaryNum += "1000"; break;
                    case '9': binaryNum += "1001"; break;
                    case 'A': binaryNum += "1010"; break;
                    case 'B': binaryNum += "1011"; break;
                    case 'C': binaryNum += "1100"; break;
                    case 'D': binaryNum += "1101"; break;
                    case 'E': binaryNum += "1110"; break;
                    case 'F': binaryNum += "1111"; break;
                }
            }

            return LeadingZeroes(binaryNum);
        }

        public static string LeadingZeroes(string number)
        {
            string zeroes = string.Empty;
            bool zero = true;

            foreach (var symbol in number)
            {
                if (zero && symbol == '0')
                {
                    continue;
                }
                else
                {
                    zero = false;
                    zeroes += symbol;
                }
            }

            return zeroes;
        }
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(HexadecimalToBinary(number));
        }
    }
}
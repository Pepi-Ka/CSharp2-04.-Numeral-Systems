namespace Binary_To_HexaDecimal
{
    using System;

    public class Binary2Hexadecimal
    {
        public static string BinToHex(string input)
        {
            input = AddZeroes(input);
            string hexNum = string.Empty;
            string binNum = string.Empty;
            for (int i = 0; i < input.Length; i += 4)
            {
                binNum = input.Substring(i, 4);

                switch (binNum)
                {
                    case "0000": hexNum += "0"; break;
                    case "0001": hexNum += "1"; break;
                    case "0010": hexNum += "2"; break;
                    case "0011": hexNum += "3"; break;
                    case "0100": hexNum += "4"; break;
                    case "0101": hexNum += "5"; break;
                    case "0110": hexNum += "6"; break;
                    case "0111": hexNum += "7"; break;
                    case "1000": hexNum += "8"; break;
                    case "1001": hexNum += "9"; break;
                    case "1010": hexNum += "A"; break;
                    case "1011": hexNum += "B"; break;
                    case "1100": hexNum += "C"; break;
                    case "1101": hexNum += "D"; break;
                    case "1110": hexNum += "E"; break;
                    case "1111": hexNum += "F"; break;
                }
            }

            return LeadingZeroes(hexNum);
        }

        public static string LeadingZeroes(string n)
        {
            string zeroes = string.Empty;
            bool zero = true;

            foreach (var ch in n)
            {
                if (zero && ch == '0')
                {
                    continue;
                }
                else
                {
                    zero = false;
                    zeroes += ch;
                }
            }

            return zeroes;
        }

        public static string AddZeroes(string number)
        {
            long length = number.Length;
            long addZero = 4 - (length % 4);

            return (new string('0', (int)addZero) + number);
        }
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(BinToHex(number));
        }
    }
}
namespace Binary_Short
{
    using System;

    public class BinaryShort
    {
        static string ShortBinary(short input)
        {
            byte[] inputByte = BitConverter.GetBytes(input);
            string toBinary = "";
            for (int i = 0; i < inputByte.Length; i++)
            {
                toBinary = Convert.ToString(inputByte[i], 2).PadLeft(8, '0') + toBinary;
            }
            return toBinary;
        }
        static void Main()
        {
            short number = short.Parse(Console.ReadLine());
            string toBinary = ShortBinary(number);
            Console.WriteLine("{0}{1}", toBinary[0], toBinary.Substring(1, 15));
        }
    }
}
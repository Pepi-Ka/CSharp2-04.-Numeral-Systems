namespace Binary_To_Decimal
{
    using System;

    public class Binary2Decimal
    {
        public static long BinaryToDecimal(string number)
        {
            long decimalN = 0;
            int index = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                int num = number[i] - 48;
                decimalN += (long)Math.Pow(2, index) * num;
                index--;
            }

            return decimalN;
        }
        static void Main()
        {
            string binaryNum = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(binaryNum));
        }
    }
}
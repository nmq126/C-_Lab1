using System;
using System.Linq;

namespace Lab2_ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sin;
            while (true)
            {
                Console.WriteLine("Enter your SIN:");
                sin = Convert.ToInt32(Console.ReadLine());
                if (sin == 0)
                {
                    break;
                }
                if (CheckValid(sin))
                {
                    Console.WriteLine("This is a valid SIN");
                }
                else
                {
                    Console.WriteLine("This is an invalid SIN");
                }
            }
            Console.WriteLine("Have a nice day!!!");
        }

        public static bool CheckValid(int sinNumber)
        {
            if (sinNumber < 100000000 || sinNumber > 999999999)
            {
                return false;
            }

            char[] charArray = sinNumber.ToString().ToCharArray();
            int[] intArray = Array.ConvertAll(charArray, c => (int) Char.GetNumericValue(c));
            int firstSum = CalculateEvenPositionDigits(intArray[1]) + 
                           CalculateEvenPositionDigits(intArray[3]) +
                           CalculateEvenPositionDigits(intArray[5]) + 
                           CalculateEvenPositionDigits(intArray[7]);
            int secondSum = intArray[0] + intArray[2] + intArray[4] + intArray[6];
            int total = firstSum + secondSum;
            int nextHighestNumberEndingInZero = ((total / 10) + 1) * 10;
            int finalNumber = nextHighestNumberEndingInZero - total;
            return (finalNumber.Equals(intArray[8]));
        }

        public static int CalculateEvenPositionDigits(int a)
        {
            a = a * 2;
            if (a < 10)
            {
                return a;
            }
            else
            {
                return a - 10 + 1;
            }
        }
    }
}
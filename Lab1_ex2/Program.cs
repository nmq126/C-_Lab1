using System;

namespace Lab1_ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter three integer:");
            Console.WriteLine("Integer 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer 3: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maximum number is {0}", FindMax(a,b,c));
            Console.ReadLine();
        }

        static int FindMax(int a, int b, int c)
        {
            int max;
            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else
                {
                    max = c;
                }
            }else if (b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            return max;
        }
    }
}
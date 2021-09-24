using System;

namespace Lab1_ex5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine("{0}! = {1}", i, Factorial(i));
            }
        }
    
        static double Factorial(int a)
        {
            if (a < 1)
            {
                return 1;
            }
            return a * Factorial(a - 1);
        }
    }
}
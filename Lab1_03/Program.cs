﻿using System;

namespace Lab1_03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int valueVal = 5;
            Test(valueVal);
            Console.WriteLine("The value of the variable is {0}", valueVal);
            Console.ReadLine();
        }

        static void Test(int valueVal)
        {
            int temp = 5;
            valueVal = temp * 2;
        }
    }
}
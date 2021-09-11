using System;

namespace Lab1_ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your address: ");
            var address = Console.ReadLine();
            Console.WriteLine("Enter your phone: ");
            var phone = Console.ReadLine();
            Console.WriteLine("Name: {0}, Address: {1}, Phone: {2}", name, address, phone);
            Console.ReadLine();
        }
    }
}
using System;

namespace Lab3_ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employee = new Employee("Minh Quang", "Ngo", "219 Tran Nhat Duat", 1234567, 99999990);
            Console.WriteLine(employee.ToString());
            Console.WriteLine("Bonus (50% salary): "+ employee.Bonus(50));
        }
    }
}
using System;
using Lab4_ex1;

namespace Lab5_ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var falcuty = new Faculty("kw1ang", "123333", "kaha@gmail.com", "lul",
                    23330000, new DateTime(2015, 6, 10), 12, "Senior Lecturer");
                if (falcuty.rank.Equals("Senior Lecturer") && falcuty.salary < 60000)
                {
                    throw new AmountException(falcuty.fullname, "Senior Lecturer must have salary over 60000");
                }

                if (falcuty.CalculateBonus() > 10000)
                {
                    throw new AmountException(falcuty.fullname, "Bonus cannot be over than 10000");

                }
            }
            catch (AmountException e)
            {
                Console.WriteLine(e.personName +" "+ e.Message);
            }
        }   
    }
}
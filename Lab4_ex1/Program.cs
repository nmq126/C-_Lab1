using System;

namespace Lab4_ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var em = new Staff("quang", "213", "quang@gmail.com", "lmao", 123, new DateTime(2020, 12, 06), "intern");
            Console.WriteLine(em.ToString());
            Console.WriteLine(em.CalculateVacation());
            Console.WriteLine(em.CalculateBonus());
            var fal = new Faculty("kwang", "123333", "kaha@gmail.com", "lul",
                90000, new DateTime(2020, 6, 10), 12, "Intern");
            Console.WriteLine(fal.ToString());
            Console.WriteLine(fal.CalculateVacation());
            Console.WriteLine(fal.CalculateBonus());
            var fal1 = new Faculty("kw1ang", "123333", "kaha@gmail.com", "lul",
                233300, new DateTime(2015, 6, 10), 12, "Senior Lecturer");
            Console.WriteLine(fal1.ToString());
            Console.WriteLine(fal1.CalculateVacation());
            Console.WriteLine(fal1.CalculateBonus());
        }
    }
}
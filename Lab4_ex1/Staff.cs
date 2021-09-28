using System;

namespace Lab4_ex1
{
    public class Staff: Employee
    {
        public string title { get; set; }

        public Staff(string fullname, string phone, string email, string department, double salary, DateTime dateHired, string title) : base(fullname, phone, email, department, salary, dateHired)
        {
            this.title = title;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double CalculateBonus()
        {
            return 0.06 * salary;
        }

        public override int CalculateVacation()
        {
            if ((DateTime.Now - dateHired).TotalDays / 365 > 5)
            {
                return 4;
            }
            return 3;
            
        }
    }
}
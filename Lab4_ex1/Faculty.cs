using System;

namespace Lab4_ex1
{
    public class Faculty: Employee
    {
        public int officeHours { get; set; }
        public string rank { get; set; }

        public Faculty(string fullname, string phone, string email, string department, double salary, DateTime dateHired, int officeHours, string rank) : base(fullname, phone, email, department, salary, dateHired)
        {
            this.officeHours = officeHours;
            this.rank = rank;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double CalculateBonus()
        {
            return 1000 + 0.05 * salary;
        }

        public override int CalculateVacation()
        {
            if ((DateTime.Now - dateHired).TotalDays / 365 > 3 && rank.Equals("Senior Lecturer"))
            {
                return 6;
            }
            else if ((DateTime.Now - dateHired).TotalDays / 365 > 3)
            {
                return 5;
            }
            return 4;
        }
    }
}
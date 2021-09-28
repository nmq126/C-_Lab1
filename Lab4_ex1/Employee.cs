using System;

namespace Lab4_ex1
{
    public abstract class Employee: Person
    {
        public string department { get; set; }
        public double salary { get; set; }
        public DateTime dateHired { get; set; }

        public Employee(string fullname, string phone, string email, string department, double salary, DateTime dateHired) : base(fullname, phone, email)
        {
            this.department = department;
            this.salary = salary;
            this.dateHired = dateHired;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract double CalculateBonus();
        public abstract int CalculateVacation();
    }
}
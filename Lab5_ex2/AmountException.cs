using System;

namespace Lab5_ex2
{
    public class AmountException: Exception
    {
        public string personName { get; set; }

        public AmountException(string personName, string message) : base(message)
        {
            this.personName = personName;
        }
    }
}
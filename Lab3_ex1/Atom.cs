using System;

namespace Lab3_ex1
{
    public class Atom
    {
        public int atomicNumber { get; set; }
        public string symbol { get; set; }
        public string fullname { get; set; }
        public float weight { get; set; }

        public bool accept()
        {
            if (string.IsNullOrEmpty(atomicNumber.ToString()) || atomicNumber < 0)
            {
                Console.WriteLine("Atomic number is invalid! Try again");
                return false;
            }
            if (string.IsNullOrEmpty(symbol))
            {
                Console.WriteLine("Symbol is invalid! Try again");
                return false;
            }
            if (string.IsNullOrEmpty(fullname))
            {
                Console.WriteLine("Fullname is invalid! Try again");
                return false;
            }
            
            if (string.IsNullOrEmpty(weight.ToString()) || weight < 0)
            {
                Console.WriteLine("Weight is invalid! Try again");
                return false;
            }

            return true;
        }

        public void display()
        {
            Console.WriteLine("{0} {1} {2} {3}", atomicNumber, symbol, fullname, weight);
        }
    }
}
using System;
using System.Collections.Generic;

namespace Lab3_ex1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Atomic Information");
            Console.WriteLine("===================");
            List<Atom> atoms = new List<Atom>();
            bool check = true;
            do
            {
                var atom = new Atom();
                Console.WriteLine("Enter atomic number: ");
                atom.atomicNumber = Convert.ToInt32(Console.ReadLine());
                if (atom.atomicNumber == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter symbol: ");
                    atom.symbol = Console.ReadLine();
                    Console.WriteLine("Enter fullname: ");
                    atom.fullname = Console.ReadLine();
                    Console.WriteLine("Enter atomic weight: ");
                    atom.weight = Convert.ToSingle(Console.ReadLine());
                    if (atom.accept())
                    {
                        atoms.Add(atom);
                    }
                    else
                    {
                        check = false;
                    }
                }
            } while (atoms.Count < 10 || !check);
            
            Console.WriteLine("No Sym Name Weight");
            foreach (var item in atoms)
            {
                item.display();
            }
        }
    }
}
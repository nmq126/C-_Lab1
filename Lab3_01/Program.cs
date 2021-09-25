using System;

namespace Lab3_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car myCar;
            Console.WriteLine("Creating a Car object and assigning " + "its memory location to myCar");
            myCar = new Car();
            
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.yearBuilt = 1995;
            
            Console.WriteLine("myCar details:");
            Console.WriteLine("myCar.make = "+ myCar.make);
            Console.WriteLine("myCar.model= "+myCar.model);
            Console.WriteLine("myCar.color = "+myCar.color);
            Console.WriteLine("myCar.yearBuilt=" +myCar.yearBuilt);
            myCar.Start();
            myCar.Stop();

            Console.WriteLine("Creating another Car object and"+" assigning its memory location to redPorsche");
            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "red";
            redPorsche.yearBuilt = 2000;
            Console.WriteLine("redPorsche is a " + redPorsche.model);

            Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redPorsche;
            Console.WriteLine("myCar details:");
            Console.WriteLine("myCar.make = " + myCar.make);
            Console.WriteLine("myCar.model = " +myCar.model);
            Console.WriteLine("myCar.color = " +myCar.color);
            Console.WriteLine("myCar.yearBuilt = "+myCar.yearBuilt);


            myCar = null;
            Console.ReadLine();
        }
    }
}
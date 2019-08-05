using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bonus_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Motors admin console!");
            Console.WriteLine();
            Console.Write("How many cars are you entering: ");
            Console.WriteLine();
            int numOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            string Make = "";
            string Model = "";
            int Year = 0;
            double Price = 0;

            for (int i = 1; i <= numOfCars; i++)
            {
                Console.Write($"Enter Car #{i} Make: ");
                Console.WriteLine();
                Make = Console.ReadLine();
                Console.Write($"Enter Car #{i} Model: ");
                Console.WriteLine();
                Model = Console.ReadLine();
                Console.Write($"Enter Car #{i} Year: ");
                Console.WriteLine();
                Year = int.Parse(Console.ReadLine());
                Console.Write($"Enter Car #{i} Price: ");
                Console.WriteLine();
                Price = Convert.ToDouble(Console.ReadLine());

                cars.Add(new Car(Make, Model, Year, Price));
            }

            Console.WriteLine();
            Console.WriteLine("Current Inventory");
            Console.WriteLine();
            foreach (var c in cars)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}

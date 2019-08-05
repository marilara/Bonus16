using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Bonus_16
{
    class Car
    {

        private string make;
        private string model;
        private int year;
        private double price;

        public Car()
        {
            this.make = "Chevrolet";
            this.model = "Traverse";
            this.year = 2018;
            this.price = 42000;
        }
        
        public string Make { get { return make; } }
        public string Model { get { return model; } }
        public int Year {  get { return year; } }
        public double Price { get { return price; } }

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public override string ToString()
        {

            return $"{Make,-15} {Model,-15} {Year,-15} {Price.ToString("C", CultureInfo.CurrentCulture),-15}";
        }
    }
}

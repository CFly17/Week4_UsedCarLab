using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_UsedCarLab_Redo
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public List<string> CarLot { get; set; } = new List<string>();

        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }

        //public Car()
        //{
        //    this.Make = "Ford";
        //    this.Model = "Focus";
        //    this.Year = 2000;
        //    this.Price = 0.0m;
        //}

        public override string ToString()
        {
            string output = $"{Year} {Make} {Model}\n";
            output += $"Price: {Price}\n";
            return output;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_UsedCarLab_Redo
{
    class UsedCar : Car
    {
        public double CurrentMileage { get; set; }
        public UsedCar(string Make, string Model, int Year, decimal Price, int CurrentMileage)
            : base(Make, Model, Year, Price)
        {
            this.CurrentMileage = CurrentMileage;
        }

        public override string ToString()
        {
            string output = $"{Year} {Make} {Model} (Used)\n";
            output += $"Price: {Price}\n";
            output += $"Mileage: {CurrentMileage}\n";
            return output;
        }

    }
}

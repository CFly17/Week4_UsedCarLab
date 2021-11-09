using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_UsedCarLab_Redo
{
    class CarLot
    {
        public static List<Car> Inventory { get; set; } = new List<Car>();
        public CarLot()
        {
            Inventory.Add(new Car("Ford", "F-150", 2021, 32000));
            Inventory.Add(new Car("Chevy", "Colorado", 2021, 30000));
            Inventory.Add(new Car("Mercedes Benz", "Popemobile", 2021, 320000));

            Inventory.Add(new UsedCar("Ford", "F-150", 2001, 7000, 202000));
            Inventory.Add(new UsedCar("Chevy", "Colorado", 2012, 18000, 60000));
            Inventory.Add(new UsedCar("Rolls Royce", "Ghost", 2018, 260000, 1000));
        }

        public void PrintCars()
        {
            for (int i = 0; i < Inventory.Count; i++)
                Console.WriteLine($"{i + 1}. {Inventory[i]}");
            //Console.WriteLine($"{i + 1} : {CarLot[i].Make} {CarLot[i].Model} - {CarLot[i].Year}");
        }

        public List<Car> AddCar()
        {
            List<Car> outputs = new List<Car>();
            Console.WriteLine("Is the car [u]sed or [n]ew?");
            string usedOrNew = Console.ReadLine();
            switch (usedOrNew)
            {
                case "n":
                    Console.WriteLine("What type of car would you like to add?\nEnter the model here:");
                    string makeToAddNew = Console.ReadLine();
                    Console.WriteLine("Which model would you like to add?");
                    string modelToAddNew = Console.ReadLine();
                    Console.WriteLine("What year is it?");
                    int yearToAddNew = int.Parse(Console.ReadLine());
                    Console.WriteLine("Finally, how much does it cost?");
                    decimal costToAddNew = decimal.Parse(Console.ReadLine());

                    //add it to Sales lot:
                    Inventory.Add(new Car(makeToAddNew, modelToAddNew, yearToAddNew, costToAddNew));
                    Console.WriteLine($"Great! we added your new {yearToAddNew} {makeToAddNew} {modelToAddNew}.\nHopefully it sells for {costToAddNew}....");
                    break;

                case "u":
                    Console.WriteLine("What type of used car would you like to add?\nEnter the model here:");
                    string makeToAddUsed = Console.ReadLine();
                    Console.WriteLine("Which model would you like to add?");
                    string modelToAddUsed = Console.ReadLine();
                    Console.WriteLine("What year is it?");
                    int yearToAddUsed = int.Parse(Console.ReadLine());
                    Console.WriteLine("How much does it cost?");
                    decimal costToAddUsed = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("How many miles are on it?");
                    int milesToAddUsed = int.Parse(Console.ReadLine());

                    //add it to the lot:
                    Inventory.Add(new UsedCar(makeToAddUsed, modelToAddUsed, yearToAddUsed, costToAddUsed, milesToAddUsed));
                    Console.WriteLine($"Great! we added your used {yearToAddUsed} {makeToAddUsed} {modelToAddUsed} with {milesToAddUsed} miles.");
                    break;
            }
            return outputs;
        }

        public void PurchaseCar()
        {

            Console.WriteLine("Which car would you like to purchase? Remember, this is our current inventory:\n");
            PrintCars();
            Console.WriteLine("\nWhat number would you like to purchase?");
            int carToPurchase = int.Parse(Console.ReadLine().ToLower().Trim()) - 1;
            Console.WriteLine($"Sure thing. Enjoy your new {Inventory[carToPurchase].Make} {Inventory[carToPurchase].Model}");
            Console.WriteLine();
            Inventory.RemoveAt(carToPurchase);
        }

        public bool Continue()
        {
            Console.WriteLine("Would you like to continue? \n[y]es or[n]o");
            string continueAnswer = Console.ReadLine();
            if (continueAnswer == "y" || continueAnswer == "yes")
                return true;
            else if (continueAnswer == "n" || continueAnswer == "no")
            {
                Console.WriteLine("Alrighty. See you later!");
                return false;
            }
            else
            {
                Console.WriteLine("Say what?");
                Continue();
            }
            return true;
        }

    }
}

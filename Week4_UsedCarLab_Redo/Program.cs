using System;

namespace Week4_UsedCarLab_Redo
{
    class Program
    {
        static void Main(string[] args)
        {

            bool goOn = true;
            CarLot c = new CarLot();

            Console.WriteLine("Welcome to the Car Lot!");
            while (goOn == true)
            {
                Console.WriteLine("What would you like to do?\n[1]See car inventory\n[2]Add a car\n[3]Purchase a car\n[4]Quit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        c.PrintCars();
                        break;
                    case 2:
                        c.AddCar();
                        break;
                    case 3:
                        c.PurchaseCar();
                        break;
                    case 4:
                        Console.WriteLine("See you later!");
                        goOn = false;
                        break;
                    default:
                        Console.WriteLine("Try a number 1-4.");
                        break;
                }
            }

        }
    }
}

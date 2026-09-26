using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageFeeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and Initialise needed variables
            int daysParked, carsParked, hoursParked;
            decimal dailyRevenue = 0;
            bool isDaysValid = true;
            bool isCarsValid = true;
            bool isHoursValid = true;

            //Displays greeting message
            Console.WriteLine("Welcome to Parking Garage System");
            Console.WriteLine();
            
            //Allows user to enter the number of days parked, and validates input
            do
            {
                Console.Write("Enter the number of days the car will be parked: ");
                isDaysValid = int.TryParse(Console.ReadLine(), out daysParked);
                if ((!isDaysValid) || (daysParked < 0))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            while ((!isDaysValid) || (daysParked < 0));
            Console.WriteLine();

            //Allows user to enter the number of cars that will be parked, and validates if the input is valid
            do
            {
                Console.Write("Enter the number of cars that will be parked: ");
                isCarsValid = int.TryParse(Console.ReadLine(), out carsParked);
                if ((!isCarsValid) || (carsParked < 0))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            while ((!isCarsValid) || (carsParked < 0));

            //Display results
            for (int dayNumber = 0; dayNumber < daysParked; dayNumber++)
            {
                dailyRevenue = 0;

                Console.WriteLine($"\nDay {dayNumber + 1}");
                for (int carNumber = 0; carNumber < carsParked; carNumber++)
                {
                    do
                    {
                        Console.Write($"Enter hours parked for car {carNumber + 1} for day {dayNumber + 1}: ");
                        isHoursValid = int.TryParse(Console.ReadLine(), out hoursParked);

                        if ((!isHoursValid)||(hoursParked < 0)||(hoursParked > 24))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number between 0 and 24.");

                            isHoursValid = false;
                        }
                    }
                    while ((!isHoursValid) || (hoursParked < 0) || (hoursParked > 24));

                    dailyRevenue += DisplayHoursParked(hoursParked, carNumber + 1);
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n\t\tTotal Parking Fee for Day {dayNumber + 1}: {dailyRevenue.ToString("C2")}");
                Console.ResetColor();
            }

            //Wait and Close Program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        //Main method

        static decimal DisplayHoursParked(int hoursParked, int carNumber)
        {
            //Declare needed variables
            decimal parkingFee = 0;

            //Check if long/short stay
            if (hoursParked <= 5)
            {
                parkingFee = hoursParked * 10m;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\tCar {carNumber} parked for {hoursParked} hours (Short Stay) costing a fee of " + parkingFee.ToString("C2") + ".");
                Console.ResetColor();
            }
            else
            {
                parkingFee = 200.00m;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\tCar {carNumber} parked for {hoursParked} hours (Long Stay) costing a fee of " + parkingFee.ToString("C2") + ".");
                Console.ResetColor();
            }

            return (parkingFee);
        }
        //DisplayHoursParked
    }
}

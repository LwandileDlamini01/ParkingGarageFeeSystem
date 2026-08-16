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
            int iDaysParked;
            int iCarsParked;
            bool isDaysValid = true;
            bool isCarsValid = true;
            bool isHoursValid = true;
            int iHoursParked;

            //Displays greeting message
            Console.WriteLine("Welcome to Parking Garage System");
            Console.WriteLine();
            
            //Allows user to enter the number of days parked, and validates input
            do
            {
                Console.Write("Enter the number of days the car will be parked: ");
                isDaysValid = int.TryParse(Console.ReadLine(), out iDaysParked);
                if ((!isDaysValid) || (iDaysParked < 0))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            while ((!isDaysValid) || (iDaysParked < 0));
            Console.WriteLine();

            //Allows user to enter the number of cars that will be parked, and validates if the input is valid
            do
            {
                Console.Write("Enter the number of cars that will be parked: ");
                isCarsValid = int.TryParse(Console.ReadLine(), out iCarsParked);
                if ((!isCarsValid) || (iCarsParked < 0))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            while ((!isCarsValid) || (iCarsParked < 0));

            //Display results
            for (int iDayNumber = 1; iDayNumber <= iDaysParked; iDayNumber++)
            {
                Console.WriteLine($"\nDay {iDayNumber}");
                for (int iCarNumber = 1; iCarNumber <= iCarsParked; iCarNumber++)
                {
                    Console.Write($"Enter hours parked for car {iCarNumber} for day {iDayNumber}: ");
                    if (int.TryParse(Console.ReadLine(), out iHoursParked))
                    {
                        if ((iHoursParked >= 0)&& (iHoursParked <= 24))
                        {
                            DisplayHoursParked(iHoursParked, iCarNumber);
                        }
                        else
                        {
                            Console.WriteLine("Invalid time range.");
                        }
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                            Console.Write($"Enter hours parked for car {iCarNumber} for day {iDayNumber}: ");
                            isHoursValid = int.TryParse(Console.ReadLine(), out iHoursParked);
                        }
                        while (!isHoursValid);

                        if ((iHoursParked >= 0) && (iHoursParked <= 24))
                        {
                            DisplayHoursParked(iHoursParked,iCarNumber);
                        }
                        else
                        {
                            Console.WriteLine("Invalid time range.");
                        }
                    }
                }
            }

            //Wait and Close Program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        //Main method

        static void DisplayHoursParked(int iHoursParked, int iCarNumber)
        {
            //Declare needed variables.

            //Check if long/short stay
            if (iHoursParked <= 5)
            {
                double dParkingFee = iHoursParked * 10d;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\tCar {iCarNumber} parked for {iHoursParked} hours (Short Stay) costing a fee of " + dParkingFee.ToString("C2") + ".");
                Console.ResetColor();
            }
            else
            {
                double dParkingFee = iHoursParked * 10d;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\tCar {iCarNumber} parked for {iHoursParked} hours (Long Stay) costing a fee of " + dParkingFee.ToString("C2") + ".");
                Console.ResetColor();
            }
        }
        //DisplayHoursParked
    }
}

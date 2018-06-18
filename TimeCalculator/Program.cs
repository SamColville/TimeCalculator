using System;

namespace TimeCalculator
{
    class MainClass
    {
        static string menuMainChoice = "";

        public static void Main(string[] args)
        {
            //Variables
            double payRate = 0;
            int menuChoiceInt;
            string payRateStr = "";


            Console.WriteLine("Welcome to the time calculator.");
            Console.WriteLine("Find out what that dress or those rollies cost in the time you work!");
            Console.WriteLine("Type 'exit' to quit at any point.");
            Console.WriteLine("First of all, we need to know how much you earn per hour.");
            payRate = GetPayRate();


            while (menuMainChoice != "3")
            {
                menuChoiceInt = MainMenu();
                switch (menuChoiceInt)
                {
                    case 1:
                        payRate = GetPayRate();
                        break;
                    case 2:
                        DisplayInHours(payRate);
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Please enter a menu option 1-3");
                        break;

                }
            }





            /*
            if(payRateStr != "exit" || newPayRateStr != "exit")
            {
                payRate = double.Parse(payRateStr);
                Console.WriteLine();
                getNewPayRate = false;
                while (getNewPayRate == false)
                {

                    Console.WriteLine("Enter how much the item(s) cost.");
                    costs = GetCost();

                    costInHours = costs / payRate;

                    Console.WriteLine("That is worth {0:0.0}hrs", costInHours);
                    Console.WriteLine("\n\n");

                    Console.Write("Would you like to enter a new hourly rate? (Y/N):  ");
                    newPayRateStr = Console.ReadLine();
                    newPayRateStr = newPayRateStr.ToLower();
                    if(newPayRateStr == "y" || newPayRateStr == "yes")
                    {
                        getNewPayRate = true;
                    }
                }

                payRateStr = GetPayRate();

            }
            */



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thank you for using this program");

        }

        static int MainMenu()
        {
            int menuChoice = 0;

            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Enter Hourly Rate");
            Console.WriteLine("2. Calculate in Hours");
            Console.WriteLine("3. Exit");
            menuMainChoice = Console.ReadLine();
            menuChoice = int.Parse(menuMainChoice);

            return menuChoice;
        }


        static double GetPayRate()
        {
            double payRate;
            Console.Write("Enter your hourly rate (exit to quit):  £");
            payRate = double.Parse(Console.ReadLine());
            return payRate;
        }

        static double GetCost()
        {
            double cost;

            Console.Write("Enter price: £");
            cost = double.Parse(Console.ReadLine());

            return cost;

        }

        static void DisplayInHours(double payRate)
        {

            double costInHours, costs;
            string payRateStr = ""; 
            bool newPayRate = false;

            while (newPayRate == false)
            {

                Console.WriteLine("Enter how much the item(s) cost.");
                costs = GetCost();

                costInHours = costs / payRate;

                Console.WriteLine("That is worth {0:0.0}hrs", costInHours);
                Console.WriteLine("\n\n");

                Console.Write("Would you like to enter a new hourly rate? (Y/N):  ");
                payRateStr = Console.ReadLine();
                payRateStr = payRateStr.ToLower();

                if (payRateStr == "y" || payRateStr == "yes")
                    newPayRate = true;
                
            }


        }



    }
}

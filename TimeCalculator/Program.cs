using System;

namespace TimeCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Variables
            double payRate = 0, costs = 0, costInHours = 0;
            string payRateStr = "", newPayRateStr = "";
            bool getNewPayRate = false;

            Console.WriteLine("Welcome to the time calculator.");
            Console.WriteLine("Find out what that dress or those rollies cost in the time you work!");
            Console.WriteLine("Type 'exit' to quit at any point.");
            Console.WriteLine("First of all, we need to know how much you earn per hour.");
            payRateStr = GetPayRate();

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



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thank you for using this program");

        }

        static string GetPayRate()
        {
            string payRate = "";

            Console.Write("Enter your hourly rate (exit to quit):  £");
            payRate = Console.ReadLine();
            payRate = payRate.ToLower();

            return payRate;
        }

        static double GetCost()
        {
            double cost;

            Console.Write("Enter price: £");
            cost = double.Parse(Console.ReadLine());

            return cost;

        }



    }
}

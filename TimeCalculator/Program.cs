using System;

namespace TimeCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Variables
            double payRate = 0, costs = 0, costInHours = 0;
            //string payRateStr, daysStr, timeInDaysStr;

            Console.WriteLine("Welcome to the time calculator.");
            Console.WriteLine("Find out what that dress or those rollies cost in the time you work!");
            Console.WriteLine("Type 'exit' to quit at any point.");
            Console.WriteLine("First of all, we need to know how much you earn per hour.");
            Console.WriteLine();
            payRate = GetPayRate();
            Console.WriteLine();
            Console.WriteLine("Next, enter how much the item(s) cost.");

            costs = GetCost();

            costInHours = costs / payRate;

            Console.WriteLine("That is worth {0:0.0}hrs", costInHours);

        }

        static double GetPayRate()
        {
            double payRate;

            Console.Write("Enter your hourly rate:  £");
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



    }
}

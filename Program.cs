using System;

namespace savings_calculator_random_monthly_interest_rate
{
    class Program
    {
        static void Main(string[] args)
        {
            // title
            Console.WriteLine("~~ Savings Calculator (Random Monthly Interest Rate) ~~");
            Console.WriteLine();

            // obtaining inputs
            Console.WriteLine("Initial deposit: ");
            var initialDeposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Number of months you plan to save for: ");
            var monthsSavedFor = double.Parse(Console.ReadLine());
            Console.WriteLine("Savings goal: ");
            var savingsGoal = double.Parse(Console.ReadLine());
            Console.WriteLine("Extra deposits every month: ");
            var extraMonthlyDeposit = double.Parse(Console.ReadLine());

            // setting a monthly random interest rate
            var randomInterestRateGenerator = new Random();
            var randomInterestRate = randomInterestRateGenerator.Next(0,101);
            var decimalInterestRate = (100d + randomInterestRate)/100d;
            Console.WriteLine();
            

            // performing calculation
            Console.WriteLine($"Your random monthly interest rate: {randomInterestRate}%");
            var maturity = (initialDeposit + extraMonthlyDeposit) * (Math.Pow(decimalInterestRate, monthsSavedFor));
            var willAchieveGoal = savingsGoal <= maturity;
            Console.WriteLine($"After {monthsSavedFor} months, you should have ${maturity}.");
            Console.WriteLine($"Will you achieve your savings goal? {willAchieveGoal}");
            Console.WriteLine();
        }
    }
}

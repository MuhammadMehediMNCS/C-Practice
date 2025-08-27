// Simple ATM Menu System
using System;

class ATM
{
    static void Main()
    {
        double balance = 1000;
        int choice;

        do
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your Balance: {balance}");
                    break;
                case 2:
                    Console.Write("Enter amount to deposit: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine($"Deposited {deposit}. New Balance: {balance}");
                    break;
                case 3:
                    Console.Write("Enter amount to withdraw: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    if (withdraw <= balance)
                    {
                        balance -= withdraw;
                        Console.WriteLine($"Withdrawn {withdraw}. New Balance: {balance}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds!");
                    }
                    break;
                case 4:
                    Console.WriteLine("Thank you for using ATM.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

        } while (choice != 4);
    }
}


/*
// Simple Quiz with Scoring
using System;

class Quiz
{
    static void Main()
    {
        int score = 0;
        string answer;

        Console.WriteLine("1. What is the capital of Bangladesh?");
        answer = Console.ReadLine();
        if (answer.ToLower() == "dhaka") score++;

        Console.WriteLine("2. 5 + 3 = ?");
        answer = Console.ReadLine();
        if (answer == "8") score++;

        Console.WriteLine("3. Which language is used for .NET?");
        answer = Console.ReadLine();
        if (answer.ToLower() == "c#" || answer.ToLower() == "csharp") score++;

        Console.WriteLine($"\nYour Score: {score}/3");
    }
}
*/
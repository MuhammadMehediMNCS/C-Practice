// Check Leap Year
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a Leap Year");
        }
        else
        {
            Console.WriteLine($"{year} is NOT a Leap Year");
        }
    }
}


/*
// Largest of 3 Numbers
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int largest = (a > b && a > c) ? a : (b > c ? b : c);

        Console.WriteLine($"Largest number is: {largest}");
    }
}
*/
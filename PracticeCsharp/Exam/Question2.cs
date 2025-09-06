// ইউজারের কাছ থেকে একটি সংখ্যা ইনপুট নিয়ে সেটা জোড় নাকি বিজোড় সংখ্যা প্রমাণ করো

using System;

class Program
{
    static void Main(string[] args)
    {
        // ইউজারের কাছ থেকে সংখ্যা ইনপুট
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // জোড় নাকি বিজোড় চেক করা
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an Even number");
        }
        else
        {
            Console.WriteLine($"{number} is an Odd number");
        }
    }
}

// ইউজারের কাছ থেকে নাম এবং বয়স ইনপুট নিয়ে নিচের আউটপুট দেখান “Hello[name], you are[age] years old”

using System;

class Program
{
    static void Main(string[] args)
    {
        // নাম ইনপুট
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // বয়স ইনপুট
        Console.Write("Enter your age: ");
        string age = Console.ReadLine();

        // আউটপুট
        Console.WriteLine($"Hello {name}, you are {age} years old");
    }
}

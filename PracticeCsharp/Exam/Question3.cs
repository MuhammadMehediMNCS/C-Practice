// একজনের বয়স ইনপুট নিন যদি বয়স ১৮ এর সমান হয় তবে প্রিন্ট করবে "You are Eligible to vote." নাহলে "Not Eligible"

using System;

class Program
{
    static void Main(string[] args)
    {
        // বয়স ইনপুট
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // শর্ত চেক
        if (age == 18)
        {
            Console.WriteLine("You are Eligible to vote.");
        }
        else
        {
            Console.WriteLine("Not Eligible");
        }
    }
}

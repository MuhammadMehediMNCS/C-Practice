// একটি অ্যারে/লিস্টে ৫টি সংখ্যা রাখো। Exception Handelling ব্যবহার করুন এবং এরপর লুপ ব্যবহার করে সবগুলো ডিসপ্লে করুন

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // অ্যারে তৈরি (৫টি সংখ্যা)
            int[] numbers = { 10, 20, 30, 40, 50 };

            // লুপ ব্যবহার করে সংখ্যা প্রিন্ট করা
            Console.WriteLine("Numbers in the array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        catch (Exception ex)
        {
            // যদি কোনো Exception ঘটে
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
}

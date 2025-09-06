// একটি প্রোগ্রাম লিখো যেখানে ইউজার 1-7 এর মধ্যে একটি সংখ্যা দিবে আর প্রোগ্রামটি সেই দিনের নাম দেখাবে (1= Monday, 2 = Tuesday..........7 = Sunday)

using System;

class Program
{
    static void Main(string[] args)
    {
        // সংখ্যা ইনপুট
        Console.Write("Enter a number (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        // switch-case ব্যবহার করে দিনের নাম দেখানো
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                break;
        }
    }
}

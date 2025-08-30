// String Formatting & Interpolation
using System;
using System.Globalization;

class FormattingDemo
{
    static void Main()
    {
        string user = "Mehedi";
        int score = 95;
        double price = 1234.567;

        // Interpolation (সবচেয়ে সহজ/পড়তে সুন্দর)
        Console.WriteLine($"Hi {user}, your score is {score}.");

        // Format specifiers
        Console.WriteLine($"Price: {price:F2}");     // 2 দশমিক: 1234.57
        Console.WriteLine($"Currency: {price:C2}");  // লোকাল কারেন্সি ফর্ম্যাট

        // string.Format বিকল্প
        Console.WriteLine(string.Format("User: {0}, Score: {1}", user, score));

        // Alignment (ডান পাশে 10-চর প্রস্থ)
        Console.WriteLine($"|{"Item",10}|{"Qty",5}|");
        Console.WriteLine($"|{"Apple",10}|{3,5}|");
    }
}

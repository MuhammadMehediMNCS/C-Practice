// আমরা চাই ব্যবহারকারী কিছু লিখবে, আর সেটি প্রোগ্রাম ব্যবহার করবে। এজন্য Console.ReadLine() ব্যবহার করা হয়
using System;
using System.Diagnostics;

class InputData
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine(); // ইউজারের ইনপুট টেক্সট হিসেবে নেবে

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine()); // ইনপুটকে সংখ্যা (int) এ রূপান্তর করল

        // String থেকে Int এ কনভার্ট
        string strNumber = "25";
        int num = Convert.ToInt32(strNumber);
        Console.WriteLine("String to Int: " + num);

        // String থেকে Double এ কনভার্ট
        string strDouble = "99.99";
        double d = Convert.ToDouble(strDouble);
        Console.WriteLine("String to Double: " + d);

        double price = 99.99;

        // Int থেকে String
        string str1 = num.ToString();
        Console.WriteLine("Int to String: " + str1);

        // Double থেকে String
        string str2 = price.ToString();
        Console.WriteLine("Double to String: " + str2);

        Console.WriteLine("Hello " + name + ", you are " + age + " years old!");
    }
}

/*
ব্যাখ্যা :
Console.ReadLine() → সব ইনপুট ডিফল্টভাবে string আকারে নেয়।

Convert.ToInt32() → ইনপুটকে integer (সংখ্যা) তে রূপান্তর করে।

Console.Write("Enter your name: ");
কনসোলে "Enter your name: " লিখে দেখাবে।
Write ব্যবহার করলে একই লাইনে কার্সর (cursor) থাকবে, নতুন লাইন শুরু হবে না।

string name = Console.ReadLine();
এখানে Console.ReadLine() ইউজারের কাছ থেকে এক লাইন টেক্সট ইনপুট নেয়।
সেই ইনপুটটি একটি string ভ্যারিয়েবল name-এ জমা হয়।

Console.Write("Enter your age: ");
কনসোলে "Enter your age: " দেখাবে এবং ইউজারকে সংখ্যা দিতে বলবে।

Console.ReadLine()
ইউজার যেটা লিখবে (যেমন: 25), সেটা ডিফল্টভাবে string আকারে আসে, মানে "25"।

Convert.ToInt32(...)
যেহেতু বয়স সংখ্যা (int), তাই আমরা string → int এ কনভার্ট করি।
ফলে "25" → 25 (সংখ্যা) হয়ে age ভ্যারিয়েবলে জমা হয়।
 */
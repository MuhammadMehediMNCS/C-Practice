// Variable হলো ডেটা রাখার বাক্স। আমরা ভ্যারিয়েবলে নাম দিয়ে ডেটা রাখতে পারি
using System;

class SomeVariables
{
    static void Main(string[] args)
    {
        int age = 20;            // সংখ্যা রাখার ভ্যারিয়েবল
        string name = "Rahim";   // টেক্সট রাখার ভ্যারিয়েবল
        double price = 99.99;    // দশমিক সংখ্যা রাখার ভ্যারিয়েবল

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Price: " + price);
    }
}

/*
ব্যাখ্যা :

int → পূর্ণ সংখ্যা রাখে (যেমন: 10, 25)

string → টেক্সট বা লেখা রাখে (যেমন: "Rahim")

double → দশমিক সংখ্যা রাখে (যেমন: 99.99)

bool → True/False মান রাখে
*/
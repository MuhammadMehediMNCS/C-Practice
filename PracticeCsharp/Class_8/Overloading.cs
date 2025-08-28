// একই নামের method, কিন্তু প্যারামিটার ভিন্ন হলে → সেটাকে method overloading বলে
using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}


// একটি Car ক্লাস তৈরি করুন যেখানে id, brand এবং model নামে তিনটি প্রোপার্টি থাকেব। মেইন মেথড থেকে গাড়ির তথ্য প্রিন্ট করবে

using System;

class Car
{
    // Properties
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }

    // Constructor
    public Car(int id, string brand, string model)
    {
        Id = id;
        Brand = brand;
        Model = model;
    }

    // Method to display car info
    public void DisplayInfo()
    {
        Console.WriteLine($"Car ID: {Id}, Brand: {Brand}, Model: {Model}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Car object তৈরি করা
        Car car1 = new Car(1, "Toyota", "Corolla");

        // গাড়ির তথ্য প্রিন্ট করা
        car1.DisplayInfo();
    }
}

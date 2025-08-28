// Real Life Example 1 : Payment System

using System;

abstract class Payment
{
    public abstract void Pay(double amount); // Must implement
}

class CreditCardPayment : Payment
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}

class PayPalPayment : Payment
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}



// Real Life Example 2 : Animal Sound
//using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat meows.");
    }
}



// Demo App : Transport System
//using System;

// Abstract Class
abstract class Vehicle
{
    public abstract void Start();   // Must override
    public abstract void Stop();    // Must override

    public virtual void FuelType()  // Can override (optional)
    {
        Console.WriteLine("Fuel type: Unknown");
    }
}

// Child class 1
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car started.");
    }
    public override void Stop()
    {
        Console.WriteLine("Car stopped.");
    }
    public override void FuelType()
    {
        Console.WriteLine("Fuel type: Petrol");
    }
}

// Child class 2
class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike started.");
    }
    public override void Stop()
    {
        Console.WriteLine("Bike stopped.");
    }
    public override void FuelType()
    {
        Console.WriteLine("Fuel type: Petrol");
    }
}

// Child class 3
class Bus : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bus started.");
    }
    public override void Stop()
    {
        Console.WriteLine("Bus stopped.");
    }
    public override void FuelType()
    {
        Console.WriteLine("Fuel type: Diesel");
    }
}


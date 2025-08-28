// Interface
using System;

interface IVehicle   // Interface
{
    void Start();   // Declaration only
    void Stop();
}

class BMWCar : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }
    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }
}

class HondaBike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike started.");
    }
    public void Stop()
    {
        Console.WriteLine("Bike stopped.");
    }
}


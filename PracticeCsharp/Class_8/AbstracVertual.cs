class Program
{
    static void Main(string[] args)
    {
        /* Shape shape = new Circle();
         shape.Draw();   // Output: Drawing a Circle.
         shape.Info();   // Output: This is a shape.*/


        // Real Life Example 1
        Payment payment1 = new CreditCardPayment();
        payment1.Pay(100);

        Payment payment2 = new PayPalPayment();
        payment2.Pay(200);


        /*// Real Life Example 2
        Animal a1 = new Dog();
        a1.Sound();  // Dog barks.

        Animal a2 = new Cat();
        a2.Sound();  // Cat meows.*/


        /*// Demo App
        Vehicle v1 = new Car();
        Vehicle v2 = new Bike();
        Vehicle v3 = new Bus();

        v1.Start(); v1.FuelType(); v1.Stop();
        v2.Start(); v2.FuelType(); v2.Stop();
        v3.Start(); v3.FuelType(); v3.Stop();*/



        /*// Interface
        IVehicle v1 = new BMWCar();
        v1.Start();  // Car started
        v1.Stop();   // Car stopped

        IVehicle v2 = new HondaBike();
        v2.Start();  // Bike started
        v2.Stop();   // Bike stopped*/




        /*// Method Overloding
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(5, 7));       // দুইটা সংখ্যা -> 12
        Console.WriteLine(calc.Add(2, 3, 4));    // তিনটা সংখ্যা -> 9
        Console.WriteLine(calc.Add(2.5, 3.5));   // দশমিক সংখ্যা -> 6.0*/
    }
}


// abstract + override + virtual

abstract class Shape
{
    public abstract void Draw(); // Abstract -> must override
    public virtual void Info()   // Virtual -> optional override
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    public override void Draw()  // Must override
    {
        Console.WriteLine("Drawing Circle.");
    }
    public override void Info()  // Optional, but overriding
    {
        Console.WriteLine("This is a Shape.");
    }
}

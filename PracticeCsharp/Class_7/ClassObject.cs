// Classes & Objects
public class Car
{
    public string Brand;
    public string Color;

    public void Drive()
    {
        Console.WriteLine($"{Brand} is driving.\nColor is {Color}");
    }
}

class OOPExample
{
    static void Main(string[] args)
    {
        // Object তৈরি
        Car car1 = new Car();
        car1.Brand = "Toyota";
        car1.Color = "Red";
        car1.Drive();

        Car car2 = new Car();
        car2.Brand = "BMW";
        car2.Color = "Black";
        car2.Drive();


        /*MathOperations math = new MathOperations();

        Console.WriteLine("Addition (int): " + math.Add(5, 7));
        Console.WriteLine("Addition (double): " + math.Add(5.5, 7.2));
        Console.WriteLine("Addition (3 params): " + math.Add(2, 3, 4));

        Console.WriteLine("Subtraction: " + math.Subtract(10, 3));
        Console.WriteLine("Multiplication: " + math.Multiply(4, 6));

        try
        {
            Console.WriteLine("Division: " + math.Divide(10, 0));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("Power: " + MathOperations.Power(2, 5));*/


        /*Cat cat = new Cat();
        cat.Eat();  // Base class থেকে
        cat.Bark(); // Own method*/


        /*Person p = new Person();
        p.Age = 25; // Setter
        Console.WriteLine(p.Age); // Getter*/
    }
}
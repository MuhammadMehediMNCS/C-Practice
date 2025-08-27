// Inheritance
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating...");
    }
}

// Derived Class
public class Cat : Animal
{
    public void Bark()
    {
        Console.WriteLine("Cat is miaowing...");
    }
}
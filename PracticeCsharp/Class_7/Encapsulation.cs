// Encapsulation
public class Person
{
    private int age; // private field

    // Getter & Setter (Property)
    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
            else
                Console.WriteLine("Invalid age!");
        }
    }
}
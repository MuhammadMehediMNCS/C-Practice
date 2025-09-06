// একটি Person ক্লাস তৈরি করুন যেখানে নাম এবং বয়স থাকবে। এরপর Student নামে আর একটি ক্লাস তৈরি করুন যেটি Person থেকে Inheritene করবে এবং সেখানে অতিরিক্ত student_id রাখবেন

using System;

// Parent Class
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Child Class
class Student : Person
{
    public int StudentId { get; set; }

    public Student(string name, int age, int studentId) : base(name, age)
    {
        StudentId = studentId;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentId}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Student object তৈরি
        Student s1 = new Student("Mehedi Hasan", 22, 101);

        // তথ্য প্রিন্ট
        s1.DisplayInfo();
    }
}

// Create Folder, File, Write data into file, Read data, Delete File and Folder
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // 1. ফোল্ডার তৈরি
            string folderPath = @"C:\DemoFolder";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder created successfully.");
            }

            // 2. ফাইল তৈরি
            string filePath = Path.Combine(folderPath, "example.txt");
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Hello, this is the first line in the file.");
                Console.WriteLine("File created and text written.");
            }

            // 3. ফাইলে ডাটা যুক্ত করা
            File.AppendAllText(filePath, "\nThis is another line.");
            Console.WriteLine("Text appended to file.");

            // 4. ফাইল থেকে ডাটা পড়া
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Content:");
            Console.WriteLine(content);

            // 5. ফাইল ডিলিট করা (কমেন্ট করলে থাকবে)
            // File.Delete(filePath);
            // Console.WriteLine("File deleted.");

            // 6. ফোল্ডার ডিলিট করা (true দিলে ভিতরের সব ফাইল ডিলিট হবে)
            // Directory.Delete(folderPath, true);
            // Console.WriteLine("Folder deleted.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

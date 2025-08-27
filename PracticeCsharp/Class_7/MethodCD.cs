// Declaring and Calling Methods
public class MathOperations
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero!");
        }
        return (double)a / b;
    }

    public static double Power(double a, double b) => Math.Pow(a, b);
}


/*
Access Modifiers :
public → সবার জন্য অ্যাক্সেসযোগ্য

private → শুধু সেই ক্লাসের ভেতরে ব্যবহারযোগ্য

internal → একই প্রজেক্ট/অ্যাসেম্বলির মধ্যে ব্যবহারযোগ্য

protected → ক্লাস এবং এর ডেরাইভড (child) ক্লাসগুলোতে ব্যবহারযোগ্য
*/
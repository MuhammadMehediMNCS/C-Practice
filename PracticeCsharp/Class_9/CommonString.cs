// Common String Methods
using System;

class CommonStringMethods
{
    static void Main()
    {
        string name = "  Md. Mehedi Hasan  ";            // স্ট্রিং (আগে/পিছে স্পেস আছে)
        Console.WriteLine(name.Length);                  // মোট ক্যারেক্টার (স্পেসসহ) গণনা
        Console.WriteLine(string.IsNullOrEmpty(name));   // যদি স্ট্রিং ফাঁকা থাকে তাহলে True আসবে
        Console.WriteLine(string.IsNullOrWhiteSpace(name));   // যদি কোনো টেক্সট না থাকে এবং স্পেস থাকে তাহলে True আসবে

        string trimmed = name.Trim();           // শুরু/শেষের স্পেস কেটে ফেলা
        Console.WriteLine(trimmed);             // "Md. Mehedi Hasan"

        Console.WriteLine(trimmed.ToUpper());   // সব ক্যাপিটাল লেটারের হবে
        Console.WriteLine(trimmed.ToLower());   // সব স্মল লেটারের হবে

        string part = trimmed.Substring(4, 6);  // 4 নম্বর index থেকে 6 ক্যারেক্টার
        Console.WriteLine(part);                // "Mehedi"

        Console.WriteLine(trimmed.Contains("Hasan"));   // সাবস্ট্রিং আছে কি? true/false
        Console.WriteLine(trimmed.StartsWith("Md."));   // "Md." দিয়ে শুরু? 
        Console.WriteLine(trimmed.EndsWith("Hasan"));    // "Hasan" দিয়ে শেষ?

        int idx = trimmed.IndexOf("Mehedi");    // সাবস্ট্রিং-এর শুরুর index (না থাকলে -1)
        Console.WriteLine(idx);

        string replaced = trimmed.Replace("Mehedi", "M.");
        Console.WriteLine(replaced);            // "Md. M. Hasan"

        string remove = trimmed.Remove(10);     // (0, 4) Md. মুছে যেতো বাঁকি সব থেকে যেতো
        Console.WriteLine(remove);            // 10 নং-এর পর থেকে যা কিছু আছে সব মুছে যাবে

        // Split & Join
        string[] words = trimmed.Split(' ');    // স্পেস দিয়ে ভেঙে অ্যারেতে
        string joined = string.Join("-", words);// অ্যারের আইটেমগুলোকে '-' দিয়ে জোড়া
        Console.WriteLine(joined);              // "Md.-Mehedi-Hasan"
    }
}



// ব্যবহার: string হলো IEnumerable<char> — তাই LINQ এক্সটেনশন দিয়ে কাজ করা যায়
using System;
using System.Linq; // Reverse(), ToArray() ইত্যাদি এক্সটেনশন এখানে

class UseLinqExtensions
{
    static void Main()
    {
        string s = "hello";
        // Reverse() স্ট্রিং নয়, IEnumerable<char> দেয়; তাই নতুন string বানাতে ToArray()
        string reversed = new string(s.Reverse().ToArray());
        Console.WriteLine(reversed); // "olleh"
    }
}




/*// নিজের Extension Method তৈরি করা
using MyExtensions;
using System;
using System.Text.RegularExpressions;

namespace MyExtensions
{
    public static class StringExtensions
    {
        // 1) ToSlug: স্পেস/নন-এলফানিউমেরিককে '-' করে, লোয়ারকেস
        public static string ToSlug(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;
            string lower = value.Trim().ToLower();
            string cleaned = Regex.Replace(lower, @"[^a-z0-9]+", "-"); // অক্ষর/সংখ্যা ছাড়া সব '-'
            cleaned = Regex.Replace(cleaned, "-{2,}", "-");            // একাধিক '-' → একটিতে
            return cleaned.Trim('-');                                  // শুরুর/শেষের '-' কাটা
        }

        // 2) TruncateSafe: নির্দিষ্ট দৈর্ঘ্যের বেশি হলে "..." যোগ
        public static string TruncateSafe(this string value, int max)
        {
            if (string.IsNullOrEmpty(value) || max < 0) return value ?? string.Empty;
            if (value.Length <= max) return value;
            if (max <= 3) return new string('.', max);
            return value.Substring(0, max - 3) + "...";
        }
    }
}

class ExtensionDemo
{
    static void Main()
    {
        string title = "  Hello, World! C# Extension Methods in Action  ";
        Console.WriteLine(title.ToSlug());           // "hello-world-c-extension-methods-in-action"
        Console.WriteLine(title.TruncateSafe(18));   // "  Hello, World!..."
    }
}

*/
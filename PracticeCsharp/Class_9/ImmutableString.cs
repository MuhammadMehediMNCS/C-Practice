// Strings Are Immutable
using System;
using System.Text;

class ImmutabilityCSharp
{
    static void Main()
    {
        string s = "A";
        s += "B";                 // পুরনো "A" বদলায় না; নতুন "AB" তৈরি হয়
        s += "C";                 // আবার নতুন "ABC"
        Console.WriteLine(s);

        // পারফরম্যান্স-ফ্রেন্ডলি উপায়
        var sb = new StringBuilder();
        for (int i = 0; i < 3; i++)
        {
            sb.Append(i);         // একই বাফারে যোগ হয়
        }
        Console.WriteLine(sb.ToString()); // "012"
    }
}

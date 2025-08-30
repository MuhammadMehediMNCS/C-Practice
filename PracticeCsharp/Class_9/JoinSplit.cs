// String Arrays/Lists & Join/Split
using System;

class ArrayJoinSplit
{
    static void Main()
    {
        string csv = "red,green,blue";
        string[] colors = csv.Split(',');           // ["red","green","blue"]

        foreach (var c in colors) Console.WriteLine(c);

        string line = string.Join(" | ", colors);   // "red | green | blue"
        Console.WriteLine(line);
    }
}

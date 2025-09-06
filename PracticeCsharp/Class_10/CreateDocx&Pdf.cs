/*// NuGet install (Package Manager Console): Open Package Manager Consol and Run 2 Commands.
// Command : Install-Package Xceed.Words.NET
// Command : Install-Package iTextSharp

using iTextSharp.text;      // PDF
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Xceed.Words.NET;       // DocX

class Program
{
    static void Main()
    {
        string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DemoFilesCSharp");
        Directory.CreateDirectory(folder);

        string wordPath = Path.Combine(folder, "Students.docx");
        string pdfPath = Path.Combine(folder, "Students.pdf");

        // ---------- CREATE ----------
        List<string> students = new List<string> { "Mehedi Hasan", "Rahim Uddin", "Karim Mia" };

        WriteWord(wordPath, students, "Student List");
        WritePdf(pdfPath, students, "Student List");
        Console.WriteLine("✅ CREATE done (Word + PDF).");

        // ---------- READ ----------
        Console.WriteLine("\n📖 Reading current data:");
        foreach (var s in students)
            Console.WriteLine(s);

        // ---------- UPDATE ----------
        students[1] = "Rahim Uddin (Updated)";
        Console.WriteLine("\n✏️ After update:");
        foreach (var s in students)
            Console.WriteLine(s);

        // ---------- DELETE ----------
        students.RemoveAt(0); // প্রথম ছাত্র ডিলিট
        Console.WriteLine("\n❌ After delete:");
        foreach (var s in students)
            Console.WriteLine(s);

        // ---------- RE-WRITE ----------
        WriteWord(wordPath, students, "Student List (Updated)");
        WritePdf(pdfPath, students, "Student List (Updated)");
        Console.WriteLine("\n✅ Word & PDF re-written after update+delete.");
    }

    static void WriteWord(string path, List<string> students, string title)
    {
        try
        {
            using var doc = DocX.Create(path);
            doc.InsertParagraph(title).Bold().FontSize(18);
            doc.InsertParagraph("-------------------");

            for (int i = 0; i < students.Count; i++)
            {
                doc.InsertParagraph($"{i + 1}. {students[i]}");
            }

            doc.Save();
        }
        catch (Exception ex)
        {
            Console.WriteLine("WriteWord Error: " + ex.Message);
        }
    }

    static void WritePdf(string path, List<string> students, string title)
    {
        try
        {
            using var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            using var doc = new iTextSharp.text.Document(PageSize.A4, 40, 40, 40, 40);
            PdfWriter.GetInstance(doc, fs);
            doc.Open();

            var p = new Paragraph(title)
            {
                Alignment = Element.ALIGN_LEFT
            };
            p.Font.Size = 18;
            p.Font.SetStyle("bold");
            doc.Add(p);

            doc.Add(new Paragraph("-------------------"));

            for (int i = 0; i < students.Count; i++)
            {
                doc.Add(new Paragraph($"{i + 1}. {students[i]}"));
            }

            doc.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("WritePdf Error: " + ex.Message);
        }
    }
}
*/
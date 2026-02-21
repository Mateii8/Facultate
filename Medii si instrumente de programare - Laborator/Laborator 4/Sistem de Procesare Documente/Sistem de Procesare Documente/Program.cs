using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_de_Procesare_Documente
{
    public class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document
            {
                Title = "Sample Document",
                Content = "This is a TEST document with MULTIPLE words.",
                Author = "John Doe"
            };
            DocumentProcessor processor = new DocumentProcessor();
            while (true)
            {
                Console.WriteLine("\nSelect processing options:");
                Console.WriteLine("1. Convert to Upper Case");
                Console.WriteLine("2. Convert to Lower Case");
                Console.WriteLine("3. Remove Whitespace");
                Console.WriteLine("4. Add Line Numbers");
                Console.WriteLine("5. Count Words");
                Console.WriteLine("6. Reverse Content");
                Console.WriteLine("7. Save Document to JSON");
                Console.WriteLine("8. Exit");
                string choice = Console.ReadLine();
                if (choice == "8") break;
                DocumentProcessorDelegate del = null;
                switch (choice)
                {
                    case "1":
                        del += DocumentProcessor.ConvertToUpperCase;
                        break;
                    case "2":
                        del += DocumentProcessor.ConvertToLowerCase;
                        break;
                    case "3":
                        del += DocumentProcessor.RemoveWhitespace;
                        break;
                    case "4":
                        del += DocumentProcessor.AddLineNumbers;
                        break;
                    case "5":
                        del += DocumentProcessor.CountWords;
                        break;
                    case "6":
                        del += DocumentProcessor.ReverseContent;
                        break;
                    case "7":
                        string filePath = "document.json";
                        DocumentProcessor.SaveDocumentToJson(doc, filePath);
                        Console.WriteLine($"\nDocument saved to {filePath}");
                        continue;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }
                processor.ProcessDocument(doc, del);
            }
        }
    }
}

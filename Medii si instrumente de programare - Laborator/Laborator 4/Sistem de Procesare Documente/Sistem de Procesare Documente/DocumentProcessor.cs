using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace Sistem_de_Procesare_Documente
{
    public delegate string DocumentProcessorDelegate(Document doc);
    public class DocumentProcessor
    {
        public string ProcessDocument(Document doc, DocumentProcessorDelegate processor)
        {
            string result = "";

            foreach (var handler in processor.GetInvocationList())
            {
                var proc = (DocumentProcessorDelegate)handler;

                result = proc(doc);

                Console.WriteLine($"\n=== Result: {proc.Method.Name} ===");
                Console.WriteLine(result);
            }

            return result;
        }
        public static string ConvertToUpperCase(Document doc) => doc.Content.ToUpper();
        public static string ConvertToLowerCase(Document doc) => doc.Content.ToLower();
        public static string RemoveWhitespace(Document doc) => string.Concat(doc.Content.Where(c => !char.IsWhiteSpace(c)));
        public static string AddLineNumbers(Document doc)
        {
            var lines = doc.Content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var numberedLines = lines.Select((line, index) => $"{index + 1}: {line}");
            return string.Join(Environment.NewLine, numberedLines);
        }
        public static string CountWords(Document doc)
        {
            var words = doc.Content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return $"Word Count: {words.Length}";
        }
        public static string ReverseContent(Document doc) => new string(doc.Content.Reverse().ToArray());

        public static void SaveDocumentToJson(Document doc, string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(doc, options);
            File.WriteAllText(filePath, json);
        }
    }
}

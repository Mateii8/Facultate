using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorValutar
{
    public class IstoricConversii
    {
        private List<string> istoric;
        public IstoricConversii()
        {
            istoric = new List<string>();
        }
        public void AdaugaInIstoric(string inregistrare)
        {
            istoric.Add($"{DateTime.Now}:{inregistrare}");
        }
        public void AfiseazaIstoric()
        {
            Console.WriteLine("Istoric Conversii:");
            foreach (var inregistrare in istoric)
            {
                Console.WriteLine(inregistrare);
            }
        }
        public void ExportaIstoric(string filePath)
        {
            System.IO.File.WriteAllLines(filePath, istoric);
            Console.WriteLine($"Istoricul a fost exportat in fisierul: {filePath}");
        }
    }
}

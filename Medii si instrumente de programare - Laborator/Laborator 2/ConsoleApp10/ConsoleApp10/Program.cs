using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introdu un text : ");
            string input = Console.ReadLine();

            StringProcessing processor = new StringProcessing(input);
            Console.WriteLine("\n--- Rezultate ---");
            Console.WriteLine($"Numar de caractere: {processor.countChar()}");
            Console.WriteLine($"Numar de cuvinte: {processor.countWords()}");
            Console.WriteLine($"Numar de propozitii: {processor.countPropozitii()}");
            Console.WriteLine($"Numar de vocale: {processor.countVocale()}");
            Console.WriteLine($"Numar de consoane: {processor.countConsoane()}");
            Console.WriteLine($"Text în majuscule: {processor.Majuscule()}");
            Console.WriteLine($"Text în minuscule: {processor.Minuscule()}");
            Console.WriteLine($"Text inversat: {processor.InvPropozitie()}");

        }
    }
}

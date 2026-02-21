using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    internal class Program
    {
        static void Main(string[] args)
        {
            const int nrStudenti = 10;
            List<double> note = new List<double>();

            
            for (int i = 0; i < nrStudenti; i++)
            {
                Console.Write($"Introdu nota studentului {i + 1}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                note.Add(nota);
            }

           
            double media = note.Average();
            double notaMin = note.Min();
            double notaMax = note.Max();
            int promovati = note.Count(n => n >= 5);

       
            Console.WriteLine($"Media clasei: {media:F2}");
            Console.WriteLine($"Nota minima: {notaMin}");
            Console.WriteLine($"Nota maxima: {notaMax}");
            Console.WriteLine($"Studenti promovați: {promovati} din {nrStudenti}");

          
            var noteCrescator = note.OrderBy(n => n);
            Console.WriteLine("\nNote sortate crescator:");
            foreach (var n in noteCrescator)
                Console.Write($"{n} ");

            
            var noteDescrescator = note.OrderByDescending(n => n);
            Console.WriteLine("\n\nNote sortate descrescator:");
            foreach (var n in noteDescrescator)
                Console.Write($"{n} ");

            Console.WriteLine();
        }
    }
}

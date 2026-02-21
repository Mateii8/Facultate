using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizatorStudenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] students = new int[10];
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"Introduceti nota studentului {(i + 1)} : ");
                int nota = int.Parse(Console.ReadLine());
                if (nota > 10 || nota<=0)
                {
                    Console.WriteLine("Nota invalida! Introduceti o nota intre 1 si 10.");
                    i--;
                    continue; // trece la urmatoarea iteratie fara sa mai execute codul urmator(nu in acest caz)
                }
                else
                {
                    students[i] = nota;
                }
            }
            GestiuneStudenti gestiune=new GestiuneStudenti(students);
            Console.WriteLine("\n--- Rezultate ---");
            Console.WriteLine($"Media notelor studentilor este : {gestiune.CalculareMedie()}");
            Console.WriteLine($"Nota maxima este : {gestiune.CalculareNotaMaxima()}");
            Console.WriteLine($"Nota minima este : {gestiune.CalculareNotaMinima()}");
            Console.WriteLine($"Numarul studentilor promovati este : {gestiune.StudentiPromovati(5)}");
            gestiune.SortareCrescator();
            gestiune.SortareDescrescator();
        }
    }
}

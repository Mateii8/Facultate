using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizatorStudenti
{
    internal class GestiuneStudenti
    {
        private int[] noteStudenti;

        public GestiuneStudenti(int[] note)
        {
            noteStudenti = note;
        }
        public double CalculareMedie()
        {
            int suma = 0;
            // calculam suma notelor folosind linq
            suma = noteStudenti.Sum();
            return (double)suma / noteStudenti.Length;
        }
        public int CalculareNotaMaxima()
        {
            return noteStudenti.Max();
        }
        public int CalculareNotaMinima()
        {
            return noteStudenti.Min();
        }

        public int StudentiPromovati(int n)
        {
            return noteStudenti.Count(nota => nota >= 5);
        }
        public void SortareCrescator()
        {
            noteStudenti = noteStudenti.OrderBy(nota => nota).ToArray();

            Console.WriteLine("Notele studentilor sortate crescator:");
            foreach (int nota in noteStudenti)
            {
                Console.Write(nota+ " ");
            }

        }
        public void SortareDescrescator()
        {
            Console.WriteLine();
            noteStudenti = noteStudenti.OrderByDescending(nota => nota).ToArray();
            Console.WriteLine("Notele studentilor sortate descrescator:");
            foreach (int nota in noteStudenti)
            {
                Console.Write(nota+" ");
            }
        }
    }

}

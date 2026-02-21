using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemGestiuneAngajati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma firma = new Firma();
            Angajati a1 = new Angajati("Matei", "Ion", 6000, "IT");
            Angajati a2 = new Angajati ("Popescu", "Ana", 5500, "CIG");
            Angajati a3 = new Angajati ("Matei", "Alexandru", 7000, "IT");
            firma.AdaugaAngajat(a1);
            firma.AdaugaAngajat(a2);
            firma.AdaugaAngajat(a3);
            Console.WriteLine("Angajatii firmei:");
            firma.AfiseazaAngajati();
            Console.WriteLine("\nSalariul mediu in departamentul IT: " + firma.SalariuMediu("IT"));
            Angajati topAngajat = firma.AngajatCuCelMaiMareSalariu();
            Console.WriteLine("\nAngajatul cu cel mai mare salariu : ");
            Console.WriteLine(topAngajat);
            a1.MarireSuma(500);
            a2.MarireProcent(10);
            Console.WriteLine("\nAngajatii dupa mariri salariale : ");
            firma.AfiseazaAngajati();
            firma.StergeAngajat("Matei","Alexandru");
            Console.WriteLine("\nAngajatii dupa stergere : ");
            firma.AfiseazaAngajati();
        }
    }
}

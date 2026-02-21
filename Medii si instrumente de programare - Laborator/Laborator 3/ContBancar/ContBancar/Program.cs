using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContBancar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cont cont1 = new Cont("Matei Ion", "RO49AAAA1B31007593840000", 400);
            Cont cont2 = new Cont("Matei Alexandru", "RO49AAAA1B31007593840001", 5000);

            cont1.Depune(200);
            cont1.Retrage(150);
            cont1.Transfer(cont2, 300);

            decimal dobanda = cont1.CalculeazaDobanda(5, 6);
            Console.WriteLine($"Dobanda estimata pentru {cont1.Titular}: {dobanda} RON");

            Console.WriteLine("Contul 1:");
            cont1.AfiseazaIstoric();
            Console.WriteLine("Contul 2:");
            cont2.AfiseazaIstoric();
        }
    }
}

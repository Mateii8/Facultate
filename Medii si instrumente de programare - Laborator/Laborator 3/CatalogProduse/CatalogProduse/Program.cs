using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogProduse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModificareProduse catalog = new ModificareProduse();
            catalog.AdaugaProdus(new Produs("Laptop", 5500.00m, "Electronice", 10));
            catalog.AdaugaProdus(new Produs("Telefon", 2500.00m, "Electronice", 15));
            catalog.AdaugaProdus(new Produs("Tricou", 350.00m, "Articole Vestimentare", 100));
            Console.WriteLine("Catalog Produse:");
            catalog.AfiseazaProduse();

            Console.WriteLine("Produse Electronice:");
            var electronice = catalog.CautaDupaCategorie("Electronice");
            electronice.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("Produse cu pret intre 300 si 3000:");
            var produseFiltrate = catalog.FiltreazaDupaPret(300.00m, 3000.00m);
            produseFiltrate.ForEach(p => Console.WriteLine(p));

            Console.WriteLine($"Valoarea totala a stocului: {catalog.ValeareTotalaStoc()}");

            Console.WriteLine("Produse cu stoc sub 11:");
            var produseSubStoc = catalog.ProduseSubStocMinim(11);
            produseSubStoc.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("Modificare pret pentru 'Telefon' la 2300.00");
            catalog.ModificaPret("Telefon", 2300.00m);
            catalog.AfiseazaProduse();

            Console.WriteLine("Stergere produs 'Tricou'");
            catalog.StergeProdus("Tricou");
            catalog.AfiseazaProduse();

        }
    }
}

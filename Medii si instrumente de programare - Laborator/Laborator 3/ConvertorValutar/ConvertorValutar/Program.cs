using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorValutar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RateSchimb rateSchimb = new RateSchimb();
            Conversii conversii = new Conversii(rateSchimb);
            IstoricConversii istoric = new IstoricConversii();
            rateSchimb.AfiseazaRate();

            decimal suma = conversii.Converteste("USD", "EUR", 100);
            Console.WriteLine($"100 USD = {suma:F2} EUR");
            istoric.AdaugaInIstoric($"100 USD = {suma:F2} EUR");
            decimal suma2 = conversii.Converteste("RON", "EUR", 200);
            Console.WriteLine($"200 RON = {suma2:F2} EUR");
            istoric.AdaugaInIstoric($"200 RON = {suma2:F3} EUR");
            rateSchimb.ActualizeazaRata("USD", 4.5m);
            decimal diferenta = rateSchimb.DiferentaRata("USD", 4.4m);
            Console.WriteLine($"Diferenta rata USD: {diferenta:F2} RON");
            istoric.AfiseazaIstoric();
            istoric.ExportaIstoric("istoric_conversii.txt");
        }
    }
}

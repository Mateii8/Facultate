using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorValutar
{
    public class RateSchimb
    {
        private Dictionary<string, decimal> rateDeSchimb;
        public RateSchimb()
        {
            rateDeSchimb = new Dictionary<string, decimal>
            {
                { "RON", 1.0m },
                { "USD", 4.4m },
                { "EUR", 5.1m },
                { "GBP", 5.7m }
            };
        }
        public decimal Converteste(decimal suma, string dinMoneda, string inMoneda)
        {
            if (!rateDeSchimb.ContainsKey(dinMoneda) || !rateDeSchimb.ContainsKey(inMoneda))
            {
                throw new ArgumentException("Moneda necunoscuta.");
            }
            decimal sumaInRON = suma * rateDeSchimb[dinMoneda];
            decimal sumaConvertita = sumaInRON / rateDeSchimb[inMoneda];
            return sumaConvertita;
        }
        public void ActualizeazaRata(string moneda, decimal nouaRata)
        {
            if (rateDeSchimb.ContainsKey(moneda))
            {
                rateDeSchimb[moneda] = nouaRata;
            }
            else
            {
                throw new ArgumentException("Moneda necunoscuta.");
            }
        }
        public decimal DiferentaRata(string moneda,decimal nouaRata)
        {
            if( rateDeSchimb.ContainsKey(moneda))
            {
                return rateDeSchimb[moneda] - nouaRata;
            }
            else
            {
                throw new ArgumentException("Moneda necunoscuta.");
            }
        }
        public void AfiseazaRate()
        {
            foreach (var rata in rateDeSchimb)
            {
                Console.WriteLine($"{rata.Key}: {rata.Value:F2} RON");
            }
        }
    }
}

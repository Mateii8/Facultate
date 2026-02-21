using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContBancar
{
    public class Cont
    {
     
            private string titular;
            private decimal sold;
            private string iban;
            private List<string> istoricTranzactii;


            public string Titular
            {
                get { return titular; }
                private set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("Titularul nu poate fi gol.");
                    titular = value;
                }
            }

            public string IBAN
            {
                get { return iban; }
                private set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("IBAN invalid.");
                    iban = value;
                }
            }

            public decimal Sold
            {
                get { return sold; }
                private set
                {
                    if (value < 0)
                        throw new InvalidOperationException("Soldul nu poate fi negativ.");
                    sold = value;
                }
            }


            public Cont(string titular, string iban, decimal soldInitial = 0)
            {
                Titular = titular;
                IBAN = iban;
                Sold = soldInitial;
                istoricTranzactii = new List<string>();
                AdaugaTranzactie($"Cont creat pentru {Titular}, sold initial: {Sold} RON");
            }


            public void Depune(decimal suma)
            {
                if (suma <= 0)
                    throw new ArgumentException("Suma de depunere trebuie să fie pozitiva.");
                Sold += suma;
                AdaugaTranzactie($"Depunere: +{suma} RON | Sold: {Sold} RON");
            }

            public void Retrage(decimal suma)
            {
                if (suma <= 0)
                    throw new ArgumentException("Suma de retragere trebuie să fie pozitiva.");
                if (Sold - suma < 0)
                    throw new InvalidOperationException("Fonduri insuficiente.");
                Sold -= suma;
                AdaugaTranzactie($"Retragere: -{suma} RON | Sold: {Sold} RON");
            }

            public void Transfer(Cont destinatar, decimal suma)
            {
                if (destinatar == null)
                    throw new ArgumentNullException(nameof(destinatar));
                if (suma <= 0)
                    throw new ArgumentException("Suma de transfer trebuie să fie pozitiva.");
                if (Sold - suma < 0)
                    throw new InvalidOperationException("Fonduri insuficiente pentru transfer.");

                this.Sold -= suma;
                destinatar.Sold += suma;

                AdaugaTranzactie($"Transfer catre {destinatar.Titular}: -{suma} RON | Sold: {Sold} RON");
                destinatar.AdaugaTranzactie($"Transfer de la {this.Titular}: +{suma} RON | Sold: {destinatar.Sold} RON");
            }

            public decimal CalculeazaDobanda(double rataDobanzii, int luni)
            {
                if (rataDobanzii < 0 || luni < 0)
                    throw new ArgumentException("Parametri invalizi pentru dobanda.");


                decimal dobanda = Sold * (decimal)(rataDobanzii / 100) * luni / 12;
                return Math.Round(dobanda, 2);
            }

            private void AdaugaTranzactie(string mesaj)
            {
                istoricTranzactii.Add($"{DateTime.Now}: {mesaj}");
            }

            public void AfiseazaIstoric()
            {
                Console.WriteLine($"--- Istoric tranzactii pentru {Titular} ---");
                foreach (var tranzactie in istoricTranzactii)
                {
                    Console.WriteLine(tranzactie);
                }
            }
    }
}

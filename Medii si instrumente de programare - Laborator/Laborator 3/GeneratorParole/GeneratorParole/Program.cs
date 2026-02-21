using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorParole
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            var optiuni = new OptiuniParola
            {
                LungimeParola =12,
                LitereMici = true,
                LitereMari = true,
                Cifre = true,
                CaractereSpeciale = true
            };
     
            var generator = new GeneratorParola();
            var parolaGenerata = generator.GenereazaParola(optiuni);
            var validareParola = new ValideazaParola();
            var putereParola=new VerificareParola();
            string mesajValidare = validareParola.Valid(parolaGenerata, optiuni) ? "Parola este valida." : "Parola nu este valida.";
            Console.WriteLine("Parola generata: " + parolaGenerata);
            Console.WriteLine("Validare parola: " + mesajValidare);
            Console.WriteLine("Putere parola: " + putereParola.VerificaParola(parolaGenerata));
            Console.ReadLine();

        }
    }
}

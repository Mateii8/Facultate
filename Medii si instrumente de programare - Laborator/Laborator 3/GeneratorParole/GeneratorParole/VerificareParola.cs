using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorParole
{
   public class VerificareParola
    {
        public string VerificaParola(string parola)
        {
            int score = 0;
            if (parola.Length >= 10)
            {
                score++;
            }
            if (parola.Any(char.IsLower))
            {
                score++;
            }
            if (parola.Any(char.IsUpper))
            {
                score++;
            }
            if (parola.Any(char.IsDigit))
            {
                score++;
            }
            if (parola.Any(ch => !char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch)))
            {
                score++;
            }
            switch(score)
            {
                case 5:
                    return "Foarte puternica";
                case 4:
                    return "Puternica";
                case 3:
                    return "Medie";
                case 2:
                    return "Slaba";
                default:
                    return "Foarte slaba";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorParole
{
    public class ValideazaParola
    {
       public bool Valid(string parola,OptiuniParola optiuni)
        {
            if(parola.Length != optiuni.LungimeParola)
            {
                return false;
            }
            if(optiuni.LitereMici && !parola.Any(char.IsLower))
            {
                return false;
            }
            if(optiuni.LitereMari && !parola.Any(char.IsUpper))
            {
                return false;
            }
            if(optiuni.Cifre && !parola.Any(char.IsDigit))
            {
                return false;
            }
            if(optiuni.CaractereSpeciale && !parola.Any(ch => !char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch)))
            {
                return false;
            }
            return true;
        }
    }
}

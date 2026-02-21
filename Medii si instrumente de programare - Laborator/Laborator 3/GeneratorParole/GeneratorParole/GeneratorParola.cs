using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorParole
{
    public class GeneratorParola
    {
        private readonly Random random = new Random();
        public string GenereazaParola(OptiuniParola optiuni)
        {
           string caracterePermise = optiuni.Caractere();
            if(string.IsNullOrEmpty(caracterePermise))
            {
                throw new ArgumentException("Nu sunt caractere permise pentru generarea parolei.");
            }
            StringBuilder parola = new StringBuilder();
            for(int i = 0; i < optiuni.LungimeParola; i++)
            {
                int index = random.Next(caracterePermise.Length);
                parola.Append(caracterePermise[index]);
            }
            return parola.ToString();
        }
    }
}

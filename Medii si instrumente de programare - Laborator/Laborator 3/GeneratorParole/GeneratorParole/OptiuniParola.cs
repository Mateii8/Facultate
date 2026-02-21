using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorParole
{
    public class OptiuniParola
    {
        public int LungimeParola { get; set; }
        public bool LitereMici { get; set; }
        public bool LitereMari { get; set; }
        public bool Cifre { get; set; }
        public bool CaractereSpeciale { get; set; }
        public string Caractere()
        {
            StringBuilder caractere = new StringBuilder();
            if (LitereMici)
            {
                caractere.Append("abcdefghijklmnopqrstuvwxyz");
            }
            if (LitereMari)
            {
                caractere.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            }
            if (Cifre)
            {
                caractere.Append("0123456789");
            }
            if (CaractereSpeciale)
            {
                caractere.Append("!@#$%^&*()-_=+[]{}|;:,.<>?/");
            }
            return caractere.ToString();
        }
    }
}

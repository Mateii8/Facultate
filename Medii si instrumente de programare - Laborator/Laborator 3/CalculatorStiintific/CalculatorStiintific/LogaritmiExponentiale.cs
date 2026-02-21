using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStiintific
{
    public class LogaritmiExponentiale
    {
        private Istoric istoric;
        public LogaritmiExponentiale(Istoric istoric)
        {
            this.istoric = istoric;
        }
        public double LogaritmBaza10(double a)
        {
            double rezultat = Math.Log10(a);
            istoric.AdaugaOperatie($"log10({a})={rezultat}");
            return rezultat;
        }
        public double LogaritmNatural(double a)
        {
            double rezultat = Math.Log(a);
            istoric.AdaugaOperatie($"ln({a})={rezultat}");
            return rezultat;
        }
        public double Exponentiala(double a)
        {
            double rezultat = Math.Exp(a);
            istoric.AdaugaOperatie($"e^{a}={rezultat}");
            return rezultat;
        }
    }
}

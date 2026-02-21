using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStiintific
{
    public class FunctiiTrigonometrice
    {
        private Istoric istoric;
        public FunctiiTrigonometrice(Istoric istoric)
        {
            this.istoric = istoric;
        }
        public double Sinus(double unghi)
        {
            double rezultat = Math.Sin(unghi);
            istoric.AdaugaOperatie($"sin({unghi})={rezultat}");
            return rezultat;
        }
        public double Cosinus(double unghi)
        {
            double rezultat = Math.Cos(unghi);
            istoric.AdaugaOperatie($"cos({unghi})={rezultat}");
            return rezultat;
        }
        public double Tangenta(double unghi)
        {
            double rezultat = Math.Tan(unghi);
            istoric.AdaugaOperatie($"tan({unghi})={rezultat}");
            return rezultat;
        }
    }
}

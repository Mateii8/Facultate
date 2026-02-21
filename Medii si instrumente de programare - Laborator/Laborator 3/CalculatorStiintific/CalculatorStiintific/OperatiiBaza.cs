using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStiintific
{
    public class OperatiiBaza
    {
        private Istoric istoric;
        public OperatiiBaza(Istoric istoric)
        {
            this.istoric = istoric;
        }
        public int Adunare(int a,int b)
        {
            int rezultat = a + b;
            istoric.AdaugaOperatie($"{a}+{b}={rezultat}");
            return rezultat;
        }
        public int Scadere(int a,int b)
        {
            int rezultat = a - b;
            istoric.AdaugaOperatie($"{a}-{b}={rezultat}");
            return rezultat;    
        }
        public int Inmultire(int a,int b)
        {
            int rezultat = a * b;
            istoric.AdaugaOperatie($"{a}*{b}={rezultat}");
            return rezultat;
        }
        public double impartire(double a,double b)
        {
            if(b==0) throw new DivideByZeroException("Impartirea la zero nu este permisa.");
            double rezultat = a / b;
            istoric.AdaugaOperatie($"{a}/{b}={rezultat}");
            return rezultat;
        }
        public double Radical(double a)
        {
            double rezultat = Math.Sqrt(a);
            istoric.AdaugaOperatie($"√{a}={rezultat}");
            return rezultat;
        }
        public double Putere(double a,double b)
        {
            double rezultat = Math.Pow(a,b);
            istoric.AdaugaOperatie($"{a}^{b}={rezultat}");
            return rezultat;
        }
        public double Modulo(double a,double b)
        {
            double rezultat = a % b;
            istoric.AdaugaOperatie($"{a}%{b}={rezultat}");
            return rezultat;
        }
    }
}

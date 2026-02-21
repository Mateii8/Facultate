using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStiintific
{
    public class Istoric
    {
        private List<string> operatii;
        public Istoric()
        {
            operatii = new List<string>();
        }
        public void AdaugaOperatie(string operatie)
        {
            operatii.Add(operatie);
        }
        public void AfiseazaIstoric()
        {
            Console.WriteLine("Istoric Operatii:");
            foreach (var operatie in operatii)
            {
                Console.WriteLine(operatie);
            }
        }
        public void GolesteIstoric()
        {
            operatii.Clear();
        }
    }
}

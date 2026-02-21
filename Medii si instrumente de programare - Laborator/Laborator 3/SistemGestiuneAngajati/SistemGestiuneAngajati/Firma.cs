using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemGestiuneAngajati
{
    public class Firma
    {
        private List<Angajati> angajati;
        public Firma()
        {
            angajati = new List<Angajati>();
        }
        public void AdaugaAngajat(Angajati angajat)
        {
            angajati.Add(angajat);
        }
        public void StergeAngajat(string nume,string prenume)
        {
            var angajat = angajati.FirstOrDefault(a => a.Nume == nume && a.Prenume == prenume);
            if (angajat!=null)
                angajati.Remove(angajat);
            else
                Console.WriteLine("Angajatul nu a fost gasit.");
        }
        public decimal SalariuMediu(string departament)
        {
            var departamentAngajati = angajati.Where(a => a.Departament == departament);
            if (!departamentAngajati.Any()) return 0;
            return departamentAngajati.Average(a => a.Salariu);
        }
        public Angajati AngajatCuCelMaiMareSalariu()
        {
            if (!angajati.Any()) return null;
            return angajati.OrderByDescending(a => a.Salariu).First();
        }
        public void AfiseazaAngajati()
        {
            foreach(var angajat in angajati)
            {
                Console.WriteLine(angajat);
            }
        }
    }
}

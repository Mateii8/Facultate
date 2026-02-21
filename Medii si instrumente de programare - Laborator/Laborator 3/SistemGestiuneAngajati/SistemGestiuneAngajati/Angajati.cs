using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemGestiuneAngajati
{
    public class Angajati
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public decimal Salariu { get; set; }
        public string Departament { get; set; }
        public Angajati(string nume, string prenume, int salariu, string departament)
        {
            Nume = nume;
            Prenume = prenume;
            Salariu = salariu;
            Departament = departament;
        }
        public void MarireProcent(decimal procent)
        {
            if(procent < 0)
            {
                throw new ArgumentException("Procentul nu poate fi negativ.");
            }
            Salariu += Salariu * procent / 100;
        }
        public void MarireSuma(decimal suma)
        {
            if(suma < 0)
            {
                throw new ArgumentException("Suma nu poate fi negativa.");
            }
            Salariu += suma;
        }
        public override string ToString()
        {
            return $"{Nume} {Prenume}, Salariu: {Salariu:F2}, Departament: {Departament}";
        }
    }
}

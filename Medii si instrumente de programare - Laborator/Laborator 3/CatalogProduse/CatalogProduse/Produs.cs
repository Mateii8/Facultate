using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogProduse
{
    public class Produs
    {
        public string nume {get; set; }
        public decimal pret { get; set; }
        public string categorie { get; set; }
        public int stoc { get; set; }
         
        public Produs(string nume, decimal pret, string categorie, int stoc)
        {
            this.nume = nume;
            this.pret = pret;
            this.categorie = categorie;
            this.stoc = stoc;
        }
        public override string ToString()
        {
            return $"Nume: {nume}, Pret: {pret}, Categorie: {categorie}, Stoc: {stoc}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogProduse
{
    public class ModificareProduse
    {
        private List<Produs> produse = new List<Produs>();
        public void AdaugaProdus(Produs produs)
        {
            produse.Add(produs);
        }
        public bool ModificaPret(string nume, decimal noulPret)
        {
            var produs = produse.FirstOrDefault(p => p.nume == nume);
            if (produs != null)
            {
                produs.pret = noulPret;
                return true;
            }
            return false;
        }
        public bool StergeProdus(string nume)
        {
            var produs = produse.FirstOrDefault(p => p.nume == nume);
            if (produs != null)
            {
                produse.Remove(produs);
                return true;
            }
            return false;
        }
        public List<Produs>CautaDupaCategorie(string categorie)
        {
            return produse.Where(p => p.categorie.ToLower() == categorie.ToLower()).ToList();
        }
        public List<Produs>FiltreazaDupaPret(decimal pretMinim, decimal pretMaxim)
        {
            return produse.Where(p => p.pret >= pretMinim && p.pret <= pretMaxim).ToList();
        }
        public decimal ValeareTotalaStoc()
        {
            return produse.Sum(p => p.pret * p.stoc);
        }
        public List<Produs>ProduseSubStocMinim(int stocMinim)
        {
            return produse.Where(p => p.stoc < stocMinim).ToList();
            Console.WriteLine("Produsele cu stoc sub minim:");
        }
        public void AfiseazaProduse()
        {
            foreach (var produs in produse)
            {
                Console.WriteLine(produs);
            }
        }
    }
}

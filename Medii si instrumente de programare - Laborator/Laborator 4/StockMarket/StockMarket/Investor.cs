using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Investor
    {
        public string Name { get; set; }
        public readonly HashSet<string> Portofolio = new HashSet<string>();
        public Investor(string name)=> Name = name;
        public void AddToPortfolio(string stockSymbol)=> Portofolio.Add(stockSymbol);
        public void Subscribe(StockMarket stockMarket)
        {
            stockMarket.StockPriceChanged += OnStockPriceChanged;
        }
        public void Unsubscribe(StockMarket stockMarket)
        {
            stockMarket.StockPriceChanged -= OnStockPriceChanged;
        }
        public void OnStockPriceChanged(object sender, StockPriceChangedEventArgs e)
        {
            if (Portofolio.Contains(e.Stock.Symbol))
            {
                string change = e.ChangeType == ChangeType.Increase ? "increased" : "decreased";
                Console.WriteLine($"Investor {Name}: Stock {e.Stock.Symbol} has {change} from {e.OldPrice:C} to {e.Stock.CurrentPrice:C}");
            }
        }
    }
}

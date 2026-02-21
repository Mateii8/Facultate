using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Stock
    {
        public string Symbol { get; set; }
        public string CompanyName { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal PreviousPrice { get; set; }
    }
    public enum ChangeType
    {
        Increase,
        Decrease,
        NoChange
    }
    public class StockPriceChangedEventArgs : EventArgs
    {
        public Stock Stock { get; set; }
        public string Symbol { get; set; }
        public decimal OldPrice { get; set; }
        public ChangeType ChangeType { get; set; }
    }
     public class StockMarket
    {
        private readonly List<Stock> stocks = new List<Stock>();
        public event EventHandler<StockPriceChangedEventArgs> StockPriceChanged;
        public void AddStock(Stock stock) => stocks.Add(stock);
        public Stock GetStock(string symbol) => stocks.FirstOrDefault(s => s.Symbol == symbol);
        public void UpdateStockPrice(string symbol, decimal newPrice)
        {
            var stock = GetStock(symbol);
            if (stock == null) return;
            var oldPrice = stock.CurrentPrice;
            if (oldPrice == newPrice) return;
            stock.PreviousPrice = oldPrice;
            stock.CurrentPrice = newPrice;
            var changeType = newPrice > oldPrice ? ChangeType.Increase : ChangeType.Decrease;
            StockPriceChanged?.Invoke(this, new StockPriceChangedEventArgs
            {
                Stock = stock,
                OldPrice = oldPrice,
                ChangeType = changeType
            });
        }
        public void SimulatePriceChanges(Random rnd)
        {
            var rand = new Random();
            foreach (var stock in stocks)
            {
                var change = (decimal)(rand.NextDouble() * 10 - 5); 
                var newPrice = Math.Max(0, stock.CurrentPrice + change); 
                UpdateStockPrice(stock.Symbol, newPrice);
            }
        }
        public IEnumerable<Stock> GetAllStocks() => stocks.AsReadOnly();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class TradingBot
    {
        private decimal buyThresholdPercent = -3.0m;
        private decimal sellThresholdPercent = 5.0m;

        public void SetBuyThreshold(decimal percent) => buyThresholdPercent = percent;
        public void SetSellThreshold(decimal percent) => sellThresholdPercent = percent;

        public void Subscribe(StockMarket market)
        {
            market.StockPriceChanged += OnStockPriceChanged;
        }

        private void OnStockPriceChanged(object sender, StockPriceChangedEventArgs e)
        {
            var stock = e.Stock;
            var oldPrice = e.OldPrice;
            var newPrice = stock.CurrentPrice;
            decimal percentChange = ((newPrice - oldPrice) / oldPrice) * 100;
            if (percentChange <= buyThresholdPercent)
            {
                Console.WriteLine($"[TRADING BOT] Buying {stock.Symbol} at {newPrice:C} (changed {percentChange:F2}%)");
            }
            else if (percentChange >= sellThresholdPercent)
            {
                Console.WriteLine($"[TRADING BOT] Selling {stock.Symbol} at {newPrice:C} (changed {percentChange:F2}%)");
            }
        }
    }
}

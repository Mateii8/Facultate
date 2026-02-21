using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public enum AlertType { Above, Below }

    public class PriceAlert
    {
        private string symbol = "";
        private decimal threshold = 0;
        private AlertType alertType;

        public void SetAlert(string symbol, decimal threshold, AlertType type)
        {
            this.symbol = symbol;
            this.threshold = threshold;
            this.alertType = type;
        }

        public void Subscribe(StockMarket market)
        {
            market.StockPriceChanged += OnStockPriceChanged;
        }

        private void OnStockPriceChanged(object sender, StockPriceChangedEventArgs e)
        {
            if (e.Symbol != symbol) return;

            bool trigger = alertType == AlertType.Above ? e.OldPrice >= threshold : e.OldPrice <= threshold;

            if (trigger)
            {
                Console.WriteLine($"[PriceAlert] {symbol} triggered! Current: {e.OldPrice:C}, Threshold: {threshold:C} ({alertType})");
            }
        }
    }

}

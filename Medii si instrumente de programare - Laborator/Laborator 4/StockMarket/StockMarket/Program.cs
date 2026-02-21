using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Program
    {
        static void Main(string[] args)
        {
            StockMarket market = new StockMarket();
            market.AddStock(new Stock { Symbol = "AAPL", CompanyName = "Apple", CurrentPrice = 150.00m });
            market.AddStock(new Stock { Symbol = "MSFT", CompanyName = "Microsoft", CurrentPrice = 300.00m });

           
            Investor investor1 = new Investor("John");
            investor1.AddToPortfolio("AAPL");
            investor1.Subscribe(market);

          
            PriceAlert alert = new PriceAlert();
            alert.SetAlert("MSFT", 310.00m, AlertType.Above);
            alert.Subscribe(market);

            TradingBot bot = new TradingBot();
            bot.SetBuyThreshold(-3.0m); 
            bot.SetSellThreshold(5.0m);  
            bot.Subscribe(market);

           
            Console.WriteLine("=== Updating Prices ===");
            market.UpdateStockPrice("AAPL", 155.00m); 
            market.UpdateStockPrice("MSFT", 315.00m); 

            Console.WriteLine("\n=== Simulating random price changes ===");
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                market.SimulatePriceChanges(rnd);
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}

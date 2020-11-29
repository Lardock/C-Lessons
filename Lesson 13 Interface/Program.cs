using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountExtraData UserAccountExtraData = new AccountExtraData();
            IStocks Stock1 = new Stocks();
            Stock1.Set("Stock","Mettals", "NLMK", "NLMK", 190m, 10, 13.8m);
            Stocks Stock2 = new Stocks(); 
            Stock2.Set("Stock","Mettals", "Severstal", "CHMF", 1100m,5 ,14.4m);
            var Stock3 = new Stocks();
            Stock3.Set("Stock", "Mettals", "Google", "GOOG", 1742m, 7, 2.3m);
            ETFs ETF1 = new ETFs(); 
            ETF1.Set("ETF", "FXIT", "FXIT","RUR", 5400m, 3);
            var ETF2 = new ETFs();
            ETF2.Set("ETF", "FXGD", "FXGD", "USA", 600m, 2);
            UserAccountExtraData.ShowAccountData();
            UserAccountExtraData.UserBalance = Stock1.Buy(UserAccountExtraData.UserBalance);
            UserAccountExtraData.UserBalance = ETF1.Sell(UserAccountExtraData.UserBalance);
            Stock2.Show();
            Console.ReadLine();
        }
    }
}

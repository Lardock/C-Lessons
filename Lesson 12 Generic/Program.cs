using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountExtraData UserAccountExtraData = new AccountExtraData();
            Stocks Stock1 = new Stocks("Stock","Mettals", "NLMK", "NLMK", 190m, 10);
            Stocks Stock2 = new Stocks("Stock","Mettals", "Severstal", "CHMF", 1100m,5);
            var Stock3 = new Stocks("Stock", "Mettals", "Google", "GOOG", 1742m, 7);
            ETFs ETF1 = new ETFs("ETF", "FXIT", "FXIT","RUR", 5400m, 3);
            var ETF2 = new ETFs("ETF", "FXGD", "FXGD", "USA", 600m, 2);
            ShowAllSecurities<Securities> ViewSecurities = new ShowAllSecurities<Securities>();
            UserAccountExtraData.ShowAccountData();
            ViewSecurities.Show(Stock1);
            ViewSecurities.Show(Stock2);
            ViewSecurities.Show(Stock3);
            ViewSecurities.Show(ETF1);
            ViewSecurities.Show(ETF2);

            Console.ReadLine();
        }
    }
}

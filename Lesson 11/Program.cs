using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountExtraData UserAccountExtraData = new AccountExtraData();
            Stocks Stock1 = new Stocks();
            Stocks Stock2 = new Stocks();
            //UserAccountExtraData.AccountExtraDataSet();
            UserAccountExtraData.ShowAccountData();
            //UserAccountExtraData.ShowAccountExtraData();

            Stock1.StockPrint();
            UserAccountExtraData.UserBalance = Stock1.StockBuy(UserAccountExtraData.UserBalance);
            Stock1.StockShowPrice();
            UserAccountExtraData.UserBalance = Stock2.StockBuy(UserAccountExtraData.UserBalance);
            UserAccountExtraData.ShowAccountData();
            Stock1.StockShow();
            Stock2.StockShow();

            Console.WriteLine($"Shares worth {Stock1+Stock2} $");
            Console.WriteLine($"Difference: {Stock1.Name}  {Stock1 - Stock2} {Stock2.Name}");
            Console.WriteLine(Stock1 == Stock2);
            Console.WriteLine(Stock1 != Stock2);
            Console.WriteLine(Stock1 > Stock2);
            Console.WriteLine(Stock1 < Stock2);
            Console.ReadLine();
        }
    }
}

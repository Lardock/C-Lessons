using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            RecursOnly RecursionTest = new RecursOnly();
            AccountExtraData UserAccountExtraData = new AccountExtraData();
            Account UserAccount = UserAccountExtraData;
            Stocks Stock1 = new Stocks();
            UserAccountExtraData = (AccountExtraData)UserAccount;
            //          UserAccountExtraData.AccountExtraDataSet();
            UserAccountExtraData.ShowAccountData();
            //          UserAccountExtraData.ShowAccountExtraData();

            Stock1.StockPrint();
            UserAccountExtraData.UserBalance = Stock1.StockBuy(UserAccountExtraData.UserBalance);
            Stock1.StockShowPrice();
            UserAccountExtraData.UserBalance = Stock1.StockBuy(UserAccountExtraData.UserBalance);
            UserAccountExtraData.ShowAccountData();
            Stock1.StockShow();


        }
    }
}

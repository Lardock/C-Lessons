using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountExtraData UserAccountExtraData = new AccountExtraData();
            Account UserAccount = UserAccountExtraData;
            Stocks Stock1 = new Stocks();
            UserAccountExtraData = (AccountExtraData)UserAccount;
            UserAccountExtraData.AccountExtraDataSet();
            UserAccountExtraData.ShowAccountData();
            UserAccountExtraData.ShowAccountExtraData();

            Stock1.StockPrint();

        }
    }
}

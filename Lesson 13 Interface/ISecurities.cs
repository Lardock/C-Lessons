using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    interface ISecurities
    {
        string Type { get; set; }
        string Name { get; set; }
        string Ticker { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }
        decimal Sum { get; set; }
        decimal Buy(decimal userBalance);

        decimal Sell(decimal userBalance);
        decimal GetSum();
        void Show();
    }
}

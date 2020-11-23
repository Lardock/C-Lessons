using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class ETFs:Securities
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }
        public string Currency { get; set; }

        public int Quantity { get; set; }
        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        private decimal sum;
        public decimal Sum
        {
            get
            {
                return sum;
            }
            set
            {
                sum=value;
            }
        }

        public ETFs(string type, string name, string ticker,string currency, decimal price, int quantity) : base(type,name, ticker, price)
        {
            Type = type;
            Name = name;
            Ticker = ticker;
            Currency = currency;
            Price = price;
            Quantity = quantity;
        }

        public void SecuritiesShow()
        {
            Console.WriteLine($"Type {Type,-10} Name {Name,-15} Ticker {Ticker,-5} Currency {Currency,-5} Price: {Price,-8} Quantity {Quantity,-8}");
            Console.WriteLine(new string('=', 40));
        }
        public decimal SumCount()
        {
            return Price * Quantity;
        }
    }
}

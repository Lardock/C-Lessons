using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class Securities
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public string Ticker { get; set; }

        public decimal Price { get; set; }

        public Securities(string type, string name, string ticker, decimal price)
        {
            Type = type;
            Name = name;
            Ticker = ticker;
            Price = price;
        }

        public void SecuritiesShow()
        {
            Console.WriteLine($"Name {Name} Ticker {Ticker} Price: {Price}");
            Console.WriteLine(new string('=',40));
        }
    }
}

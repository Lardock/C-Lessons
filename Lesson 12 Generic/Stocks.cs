using System;


namespace Lesson12
{
    class Stocks:Securities
    {
        public string Type { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }
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
                sum = SumCount();
            }
        }

        public Stocks(string type,string group, string name, string ticker, decimal price, int quantity) : base(type, name, ticker, price)
        {
            Quantity = quantity;
            Type = type;
            Group = group;
            Name = name;
            Ticker = ticker;
            Price = price;
        }

        public decimal StockBuy (decimal userBalance)
        {
            Console.WriteLine($"Enter how many pieces you want to buy ({Name})");
            int stocks;
            ReRead:
            if(int.TryParse(Console.ReadLine(),out stocks))
            {
                if (userBalance >= (stocks * Price))
                {
                    userBalance -= stocks * Price;
                    Quantity += stocks;
                    Console.WriteLine($"You bought {stocks} stocks at the {Price}. |  Your balance {userBalance}");
                    Sum = SumCount();
                    return userBalance;
                }
                else
                {
                    Console.WriteLine(new String('=',20));
                    Console.WriteLine($"Not enough money. Still needed {stocks*Price-userBalance}");
                    return userBalance;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid value");
                goto ReRead;
            }
        }

        public void StockShowPrice()
        {
            Random rand = new Random();
            Price += rand.Next(-10,10);
            Console.WriteLine();
            Console.WriteLine( $"{Name} Price for today {Price}");
            Console.WriteLine(new String('=', 40));
        }

        public void SecuritiesShow()
        {
            Sum = SumCount();
            Console.WriteLine($"Type {Type,-10} Name {Name,-15} | Quantity {Quantity,-5} | Price per share {Price,-8} | Sum {Sum}");
        }

        public decimal SumCount()
        {
            return Price * Quantity;
        }
    }
}


using System;


namespace Lesson13
{
    class Stocks:IStocks
    {
        public string Type { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Dividend { get; set; }
        public decimal Sum { get; set; }

        public void Set(string type, string group, string name, string ticker, decimal price, int quantity, decimal dividend)
        {
            Quantity = quantity;
            Type = type;
            Group = group;
            Name = name;
            Ticker = ticker;
            Price = price;
            Dividend = dividend;
        }

        public decimal Buy(decimal userBalance)
        {
            Console.WriteLine($"Enter how many pieces you want to buy ({Name})");
            int stocks;
        ReRead:
            if (int.TryParse(Console.ReadLine(), out stocks))
            {
                if (userBalance >= (stocks * Price))
                {
                    userBalance -= stocks * Price;
                    Quantity += stocks;
                    Console.WriteLine($"You bought {stocks} stocks at the {Price}. |  Your balance {userBalance}");
                    Sum = GetSum();
                    return userBalance;
                }
                else
                {
                    Console.WriteLine(new String('=', 20));
                    Console.WriteLine($"Not enough money. Still needed {stocks * Price - userBalance}");
                    return userBalance;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid value");
                goto ReRead;
            }
        }

        public decimal Sell(decimal userBalance) 
        {
            Console.WriteLine($"Enter how many pieces you want to sell ({Name})");
            int stocks;
        ReRead:
            if (int.TryParse(Console.ReadLine(), out stocks))
            {
                if (Quantity >= (stocks * Price))
                {
                    Quantity -= stocks;
                    userBalance += stocks * Price;
                    Console.WriteLine($"You sold {stocks} stocks at the {Price}. |  Your balance {userBalance}");
                    Sum = GetSum();
                    return userBalance;
                }
                else
                {
                    Console.WriteLine(new String('=', 20));
                    Console.WriteLine($"You don't have as many shares. Your shares {Quantity}");
                    return userBalance;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid value");
                goto ReRead;
            }
        }

        public void Show()
        {
            Sum = GetSum();
            Console.WriteLine($"Type {Type,-10} Name {Name,-15} | Quantity {Quantity,-5}| Divedend {Dividend} | Price per share {Price,-8} | Sum {Sum}");
        }

        public decimal GetSum()
        {
            return Price * Quantity;
        }
    }
}


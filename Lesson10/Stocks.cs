﻿using System;


namespace Lesson10
{
    class Stocks
    {
        public string Group { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }
        public int Quantity { get; set; }
        private Decimal price;
        public Decimal Price
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

        public Stocks()
        {
            Console.WriteLine("Enter from which group the stock");
            Group = Console.ReadLine();
            Console.WriteLine("Enter the stock name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the stock ticker");
            Ticker = Console.ReadLine();
            Console.WriteLine("Enter the stock price");
        Converter:
            try
            {
                Price = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter correct price!");
                goto Converter;
            }
        }

        public void StockPrint()
        {
            Console.WriteLine($"Group: {Group} | Stock Name: {Name} | Ticker: {Ticker} | Price: {Price}");
        }

        public decimal StockBuy (decimal userBalance)
        {
            Console.WriteLine("Enter how many pieces you want to buy");
            int stocks;
            ReRead:
            if(int.TryParse(Console.ReadLine(),out stocks))
            {
                if (userBalance >= (stocks * Price))
                {
                    userBalance -= stocks * Price;
                    Quantity += stocks;
                    Console.WriteLine($"You bought {stocks} stocks at the {Price}. |  Your balance {userBalance}");
                    return userBalance;
                }
                else
                {
                    Console.WriteLine(new String('=',20));
                    Console.WriteLine($"Not enought money. Still needed {stocks*Price-userBalance}");
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
        }

        public void StockShow()
        {
            Console.WriteLine("Your stocks");
            Console.WriteLine(new String('=',20));
            Console.WriteLine($"Name {Name} | Quantity {Quantity} | Price per share {Price} | Sum {Price*Quantity}");
        }
    }
}


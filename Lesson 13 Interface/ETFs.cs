using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class ETFs:IETF
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }
        public string Currency { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Sum { get; set; }
        public void Set(string type, string name, string ticker, string currency, decimal price, int quantity)
        {
            Type = type;
            Name = name;
            Ticker = ticker;
            Currency = currency;
            Price = price;
            Quantity = quantity;
        }
        public decimal Buy(decimal userBalance)
        {
            Console.WriteLine($"Enter how many pieces you want to buy ({Name})");
            int etfs;
        ReRead:
            if (int.TryParse(Console.ReadLine(), out etfs))
            {
                if (userBalance >= (etfs * Price))
                {
                    userBalance -= etfs * Price;
                    Quantity += etfs;
                    Console.WriteLine($"You bought {etfs} ETFs at the {Price}. |  Your balance {userBalance}");
                    Sum = GetSum();
                    return userBalance;
                }
                else
                {
                    Console.WriteLine(new String('=', 20));
                    Console.WriteLine($"Not enough money. Still needed {etfs * Price - userBalance}");
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
            int etfs;
        ReRead:
            if (int.TryParse(Console.ReadLine(), out etfs))
            {
                if (Quantity >= (etfs * Price))
                {
                    Quantity -= etfs;
                    userBalance += etfs * Price;
                    Console.WriteLine($"You sold {etfs} ETFs at the {Price}. |  Your balance {userBalance}");
                    Sum = GetSum();
                    return userBalance;
                }
                else
                {
                    Console.WriteLine(new String('=', 20));
                    Console.WriteLine($"You don't have as many ETFs. Your ETFs {Quantity}");
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
            Console.WriteLine($"Type {Type,-10} Name {Name,-15} Ticker {Ticker,-5} Currency {Currency,-5} Price: {Price,-8} Quantity {Quantity,-8}");
            Console.WriteLine(new string('=', 40));
        }
        public decimal GetSum()
        {
            return Quantity * Price;    
        }
    }
}

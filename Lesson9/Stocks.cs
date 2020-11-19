using System;


namespace Lesson9
{
    class Stocks
    {
        public string Group { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }
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
                Console.WriteLine( $"Group: {Group} | Stock Name: {Name} | Ticker: {Ticker} | Price: {Price}");
        }
    }
}

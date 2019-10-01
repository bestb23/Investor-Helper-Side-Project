using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelper.Models
{
    public class CollectStockList
    {
        List<Stock> Stocks = new List<Stock>();

        public List<Stock> Run()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Enter stock symbol: ");
                string stockSymbol = Console.ReadLine().ToUpper();

                Console.WriteLine("Enter stock price: ");
                decimal stockPrice = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter total stock holdings: ");
                decimal stockHoldings = decimal.Parse(Console.ReadLine());

                Stock stock = new Stock(stockSymbol, stockPrice, stockHoldings);
                Stocks.Add(stock);

                foreach (Stock enteredStock in Stocks)
                {
                    Console.WriteLine($"Symbol: {enteredStock.StockSymbol} ..... Price: {enteredStock.StockPrice} ..... Holdings: {enteredStock.StockHoldings}");
                }

                Console.WriteLine();
                Console.WriteLine("Press enter to input a new stock or (x) to continue to investment calculation: ");
                string exitLoop = Console.ReadLine().ToLower();
                if (exitLoop == "x")
                {
                    break;
                }
            }

            return Stocks;
        }
    }
}

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
                Console.WriteLine("Enter stock symbol, stock price, and stock" +
                    " holdings separated by commas(APPL, 298, 10000)(or enter x to exit): ");
                string[] investorInputs = Console.ReadLine().Split(",");
                string stockSymbol = investorInputs[0];
                if (stockSymbol == "x")
                {
                    break;
                }
                decimal stockPrice;
                bool stockPriceSuccess = decimal.TryParse(investorInputs[1], out stockPrice);
                //decimal stockPrice = decimal.Parse(investorInputs[1]);
                //decimal stockHoldings = decimal.Parse(investorInputs[2]);
                decimal stockHoldings;
                bool stockHoldingsSuccess = decimal.TryParse(investorInputs[2], out stockHoldings);

                if (!stockPriceSuccess || !stockHoldingsSuccess)
                {
                    Console.WriteLine("Incorrect input, please try again (did not find number " +
                        "values where stock price or holdings are to be entered.).");
                    continue;
                }

                Stock stock = new Stock(stockSymbol, stockPrice, stockHoldings);
                Stocks.Add(stock);

                foreach (Stock enteredStock in Stocks)
                {
                    Console.WriteLine($"Symbol: {enteredStock.StockSymbol} ..... Price: {enteredStock.StockPrice} ..... Holdings: {enteredStock.StockHoldings}");
                }

                Console.WriteLine();
            }

            return Stocks;
        }
    }
}

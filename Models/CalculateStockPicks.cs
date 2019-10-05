using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelper.Models
{
    public class CalculateStockPicks
    {
        List<string> Instructions = new List<string>();

        public List<string> Run(List<Stock> Stocks)
        {
            Console.WriteLine("Enter the amount of funds available to invest");
            string fundsAvailableInput = Console.ReadLine();
            //decimal fundsAvailable = decimal.Parse(Console.ReadLine());
            decimal fundsAvailable;
            bool fundsAvailableSuccess = decimal.TryParse(fundsAvailableInput, out fundsAvailable);

            if (!fundsAvailableSuccess)
            {
                Console.WriteLine("Incorrect input(not a number) please try again. ");
                this.Run(Stocks);
            }

            int k = 0;
            while (true)
            {
                Stock highestStockHolding = Stocks[0];
                Stock lowestStockHolding = Stocks[0];

                int j = 0;

                // deteremine highest and lowest stock holdings
                for (int i = 0; i < Stocks.Count - 1; i++)
                {
                    if (Stocks[i + 1].StockHoldings > highestStockHolding.StockHoldings)
                    {
                        highestStockHolding = Stocks[i + 1];
                    }
                    if (Stocks[i + 1].StockHoldings < lowestStockHolding.StockHoldings)
                    {
                        lowestStockHolding = Stocks[i + 1];
                        j = i + 1;
                    }
                }

                decimal difference = highestStockHolding.StockHoldings - lowestStockHolding.StockHoldings;

                int sharesToBuy = (int)difference / (int)lowestStockHolding.StockPrice;

                if (sharesToBuy == 0)
                {
                    Stocks.Remove(lowestStockHolding);
                }

                if (sharesToBuy * lowestStockHolding.StockPrice <= fundsAvailable && k < Stocks.Count && sharesToBuy != 0)
                {
                    fundsAvailable -= sharesToBuy * lowestStockHolding.StockPrice;
                    Stocks[j].StockHoldings += sharesToBuy * lowestStockHolding.StockPrice;

                    Instructions.Add($"Buy {sharesToBuy} shares of {lowestStockHolding.StockSymbol}.");
                    Stocks.Remove(lowestStockHolding);
                }
                else
                {
                    break;
                }

                k++;
            }
            return Instructions;
        }
    }
}

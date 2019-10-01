﻿using System;
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
            decimal fundsAvailable = decimal.Parse(Console.ReadLine());

            while (true)
            {
                Stock highestStockHolding = Stocks[0];
                Stock lowestStockHolding = Stocks[0];

                for (int i = 0; i < Stocks.Count - 1; i++)
                {
                    if (Stocks[i + 1].StockHoldings > Stocks[i].StockHoldings)
                    {
                        highestStockHolding = Stocks[i + 1];
                    }
                    if (Stocks[i + 1].StockHoldings < Stocks[i].StockHoldings)
                    {
                        lowestStockHolding = Stocks[i + 1];
                    }
                }

                decimal difference = highestStockHolding.StockHoldings - lowestStockHolding.StockHoldings;

                int sharesToBuy = (int)difference / (int)lowestStockHolding.StockHoldings;

                if (sharesToBuy * lowestStockHolding.StockPrice < fundsAvailable)
                {
                    fundsAvailable -= sharesToBuy * lowestStockHolding.StockPrice;
                    lowestStockHolding.StockHoldings += sharesToBuy * lowestStockHolding.StockPrice;

                    Instructions.Add($"Buy {sharesToBuy} shares of {lowestStockHolding.StockSymbol}.");
                }
                else
                {
                    break;
                }
            }
            return Instructions;
        }
    }
}
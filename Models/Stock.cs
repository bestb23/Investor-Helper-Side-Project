using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelper.Models
{
    public class Stock
    {
        public string StockSymbol { get; set; }
        public decimal StockPrice { get; set; }
        public decimal StockHoldings { get; set; }

        public Stock(string stockSymbol, decimal stockPrice, decimal stockHoldings)
        {
            StockSymbol = stockSymbol;
            StockPrice = stockPrice;
            StockHoldings = stockHoldings;
        }
    }
}

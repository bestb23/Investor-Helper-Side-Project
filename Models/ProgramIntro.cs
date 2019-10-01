using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelper.Models
{
    public class ProgramIntro
    {
        public void Run()
        {
            Console.WriteLine(@"This investor helper collects information from
the user about their investment account; including 
stock symbol, total amount invested, and stock price. ");
            Console.WriteLine();
            Console.WriteLine(@"The goal of this program is to keep total amounts in 
several funds roughly equivalent by investing more money in 
the lowest funded stocks.  This technique should allow for 
buying the lowest priced stocks and prevent buying stocks 
that are high. This investment program works best for a 
diversified portfolio of ETFs or Index Funds.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue: ");
            Console.ReadKey();
        }
    }
}

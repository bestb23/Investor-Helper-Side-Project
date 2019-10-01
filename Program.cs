using InvestorHelper.Models;
using System;
using System.Collections.Generic;

namespace InvestorHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramIntro intro = new ProgramIntro();
            intro.Run();

            CollectStockList collect = new CollectStockList();

            CalculateStockPicks calculate = new CalculateStockPicks();
            List<string> instructionList = calculate.Run(collect.Run());

            foreach (string instruction in instructionList)
            {
                Console.WriteLine(instruction);
            }

            Console.ReadKey();
        }
    }
}

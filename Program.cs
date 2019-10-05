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

            if (instructionList.Count == 0)
            {
                Console.WriteLine("Could not determine best investment action " +
                    "to take. Maybe wait for more investment funds to be available.");
            }
            else
            {
                foreach (string instruction in instructionList)
                {
                    Console.WriteLine(instruction);
                }
            }

            Console.WriteLine("All done!");
            Console.ReadKey();
        }
    }
}

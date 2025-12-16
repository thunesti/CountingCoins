using System;
using System.Collections.Generic;
using System.Text;

namespace CountingCoins
{
    internal class ShowResult
    {
        private CountService countService;
        private CalculateSum calculateSum;

        public ShowResult(CountService countService, CalculateSum calculateSum)
        {
            this.countService = countService;
            this.calculateSum = calculateSum;
        }
        public void Display()
        {
            int[] coinValues = countService.GetCoinValues();
            int[] coinCounts = countService.GetCoinCounts();
            int totalSum = calculateSum.GetTotalSum();

            for (int i = 0; i < coinValues.Length; i++)
            {
                Console.WriteLine($"You have {coinCounts[i]} coins of value {coinValues[i]}");
            }
            Console.WriteLine($"Total sum: {totalSum}");
        }
    }
}

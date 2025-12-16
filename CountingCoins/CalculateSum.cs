using System;
using System.Collections.Generic;
using System.Text;

namespace CountingCoins
{
    internal class CalculateSum
    {
        private CountService coinCounts;
        private int totalSum;

        public CalculateSum(CountService coinCounts)
        {
            this.coinCounts = coinCounts;
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            int total = 0;
            for (int i = 0; i < coinCounts.GetCoinValues().Length; i++)
            {
                total += coinCounts.GetCoinValues()[i] * coinCounts.GetCoinCounts()[i];
            }
            totalSum = total;
        }
        public int GetTotalSum()
        {
            return totalSum;
        }
    }
}

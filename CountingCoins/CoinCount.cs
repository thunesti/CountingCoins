using System;
using System.Collections.Generic;
using System.Text;

namespace CountingCoins
{
    internal class CountService
    {
        private Coins coins;
        private int[] coinCounts;

        public CountService(Coins coins, int minCount, int maxCount)
        {
            this.coins = coins;
            coinCounts = new int[4];
            var randomCount = new Random();
            for (int i = 0; i < coinCounts.Length; i++)
            {
                coinCounts[i] = randomCount.Next(minCount, maxCount);
            }
        }
        public int[] GetCoinCounts()
        {
            return coinCounts;
        }
        public int[] GetCoinValues()
        {
            return coins.GetCoinValues();
        }
    }
}
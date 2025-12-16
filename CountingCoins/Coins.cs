using System;
using System.Collections.Generic;
using System.Text;

namespace CountingCoins
{
    internal class Coins
    {
        private int[] coinValues = [1, 5, 10, 20];
        public int[] GetCoinValues()
        {
            return coinValues;
        }
    }
}

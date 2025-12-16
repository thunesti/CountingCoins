namespace CountingCoins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coins coins = new Coins();
            int minCount = 0;
            int maxCount = 10;
            CountService countService = new CountService(coins, minCount, maxCount);
            CalculateSum calculateSum = new CalculateSum(countService);
            ShowResult showResult = new ShowResult(countService, calculateSum);

            showResult.Display();

            Console.ReadKey();
        }
    }
}

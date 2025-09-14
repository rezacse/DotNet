namespace Programming.LeetCode
{
    public class BestTimeToBuy
    {
        public BestTimeToBuy()
        {

        }



        //public int CalculateProfit(int[] prices)
        //{
        //    int p = 0;
        //    for (int i = 1; i < prices.Length; i++)
        //    {
        //        if (prices[i] > prices[i - 1])
        //            p += prices[i] - prices[i - 1];
        //    }
        //}

        public int CalculateProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int p = 0;
            int lmin = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < lmin) lmin = prices[i];
                else if (prices[i] > lmin)
                {
                    p += prices[i] - lmin;
                    lmin = prices[i];
                }
            }

            return p;
        }
    }
}

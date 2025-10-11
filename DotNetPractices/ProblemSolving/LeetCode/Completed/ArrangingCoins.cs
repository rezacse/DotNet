using System;

namespace ProblemSolving.LeetCode.Completed
{
    public class ArrangingCoins
    {
        //public int GetNoOfStairs(int n)
        //{
        //    int s = 1;
        //    while (s <= n)
        //    {
        //        n -= s;
        //        s++;
        //    }

        //    return s - 1;
        //}

        public int GetNoOfStairs(int n)
        {
            return (int)(Math.Sqrt(2 * n + 0.25) - 0.5);
        }

    }
}

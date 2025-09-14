using System.Collections.Generic;
using System.Linq;

namespace Programming.LeetCode.TopInterviews
{
    public class TopKFrequentSolution
    {

        public int[] TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            foreach (int n in nums)
            {
                if (dict.ContainsKey(n)) dict[n]++;
                else dict[n] = 1;
            }

            var res = new int[k];
            var i = 0;
            foreach (var n in dict.OrderByDescending(d => d.Value))
            {
                res[i] = n.Key;
                i++;
                if (i >= k) break;
            }
            return res;
        }
    }
}

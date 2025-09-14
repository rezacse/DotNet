using System;
using System.Collections.Generic;

namespace Programming.LeetCode.TopInterviews
{
    public class RomanToIntSolution
    {
        Dictionary<char, int> mapper = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

        public int RomanToInt(string s)
        {
            int resuslt = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                resuslt += mapper[s[i]];
                if (i > 0 && mapper[s[i - 1]] < mapper[s[i]])
                {
                    resuslt -= mapper[s[i - 1]];
                    i--;
                }

            }
            return resuslt;
        }
    }
}

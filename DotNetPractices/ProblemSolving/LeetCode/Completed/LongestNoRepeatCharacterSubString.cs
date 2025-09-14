using System;
using System.Collections.Generic;

namespace Programming.LeetCode.TopInterviews
{
    public class LongestNoRepeatCharacterSubString
    {
        public int LengthOfLongestSubstring(string s)
        {
            int len = 0;
            var hash = new Dictionary<char, int>();

            for (int si = 0, ei = 0; ei < s.Length; ei++)
            {
                if (hash.ContainsKey(s[ei]))
                    si = Math.Max(hash[s[ei]], si);

                len = Math.Max(len, ei - si + 1);

                hash[s[ei]] = ei + 1;
            }

            return len;
        }

        //public int LengthOfLongestSubstring(string s)
        //{
        //    int len = 0;
        //    var lsl = string.Empty;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        var ind = lsl.IndexOf(s[i]);
        //        if(ind == -1)
        //        {
        //            lsl = $"{lsl}{s[i]}";
        //            continue;
        //        }
        //        if (lsl.Length > len) len = lsl.Length;

        //        lsl = $"{lsl.Substring(ind + 1, lsl.Length - ind - 1)}{s[i]}";
        //    }

        //    if (lsl.Length > len) len = lsl.Length;

        //    return len;
        //}

    }
}

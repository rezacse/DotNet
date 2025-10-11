using System.Text;

namespace ProblemSolving.LeetCode.Completed;
public class StringCompression
{
    public string CompressStringII(string s)
    {
        if (string.IsNullOrEmpty(s)) return s;

        StringBuilder sb = new();

        int count = 1;
        char prevChar = s[0];
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == prevChar && count < 9)
            {
                count++;
            }
            else
            {
                sb.Append(count).Append(prevChar);
                prevChar = s[i];
                count = 1;
            }

            //if (s[i] == prevChar)
            //{
            //    count++;
            //    if (count > 9)
            //    {
            //        sb.Append(--count);
            //        sb.Append(prevChar);
            //        prevChar = s[i];
            //        count = 1;
            //    }
            //}
            //else
            //{
            //    sb.Append(count);
            //    sb.Append(prevChar);
            //    prevChar = s[i];
            //    count = 1;
            //}
        }

        sb.Append(count).Append(prevChar);
        return sb.ToString();
    }


    public int CompressString(char[] chars)
    {
        if (chars.Length <= 2) return chars.Length;


        int l = 1, cc = 1;
        char prevChar = chars[0];
        for (int i = 1; i < chars.Length; i++)
        {
            if (prevChar == chars[i])
            {
                if (cc == 1) l++;

                cc++;
            }
            else
            {
                l += cc > 1 ? cc.ToString().Length : 1;
                cc = 1;
                prevChar = chars[i];
                //chars[l - 1] = cc.ToString();
            }
        }

        if (cc > 9) l += cc.ToString().Length - 1;

        return l;
    }
}

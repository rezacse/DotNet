namespace Programming.LeetCode.TopInterviews
{
    public class ReverseStringSolution
    {

        public void ReverseString(char[] s)
        {
            for (int i = 0; i < (s.Length / 2); i++)
            {
                var temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
                //(s[s.Length - i - 1], s[i]) = (s[i], s[s.Length - i - 1]);
            }
        }
    }
}

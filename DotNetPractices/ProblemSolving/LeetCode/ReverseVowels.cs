using System.Linq;

namespace Programming.LeetCode.July
{
    public class ReverseVowelsSolution
    {
        public string ReverseVowels(string s)
        {
            if (s.Length == 1) return s;

            int i = 0, j = s.Length - 1;
            var vs = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var o = new char[s.Length];
            while (i <= j)
            {
                if (!vs.Contains(s[i])) {
                    o[i] = s[i];
                    i++;
                }
                if (!vs.Contains(s[j]))
                {
                    o[j] = s[j];
                    j--;
                }

                if (vs.Contains(s[i]) && vs.Contains(s[j]))
                {
                    o[i] = s[j];
                    o[j] = s[i];
                    i++;
                    j--;
                }
            }

            return string.Join("", o);

        }

    }
}

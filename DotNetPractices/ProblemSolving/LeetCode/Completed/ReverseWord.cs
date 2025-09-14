namespace Programming.LeetCode.July
{
    public class ReverseWord
    {
        public string ReverseWords(string s)
        {
            string rw = "";
            var words = s.Split(new[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (var w in words)
                rw = rw.Length > 0 ? $"{w} {rw}" : w;

            return rw;
        }

        //public string ReverseWords(string s)
        //{
        //    string rw = "";
        //    int i = 0;
        //    while (i < s.Length)
        //    {
        //        var w = GetWord(s, ref i);
        //        if (w.Length > 0) rw = rw.Length > 0 ? $"{w} {rw}" : w;
        //        i++;
        //    }
        //    return rw;
        //}

        //public string GetWord(string s, ref int si)
        //{
        //    string w = "";
        //    while (si < s.Length && s[si] != ' ')
        //    {
        //        w = $"{w}{s[si]}";
        //        si++;
        //    }
        //    return w;
        //}
    }
}

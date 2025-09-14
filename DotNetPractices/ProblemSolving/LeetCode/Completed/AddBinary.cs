namespace Programming.LeetCode.July
{
    public class AddBinarys
    {
        public string AddBinary(string a, string b)
        {
            int len = a.Length > b.Length ? a.Length : b.Length;
            if (a.Length > b.Length)
            {
                for (int i = b.Length; i < len; i++)
                    b = $"0{b}";
            }

            if (a.Length < b.Length)
            {
                for (int i = a.Length; i < len; i++)
                    a = $"0{a}";
            }

            int c = 0;
            string s = "";
            for (int i = len - 1; i >= 0; i--)
            {
                if (i < a.Length) c += int.Parse(a[i].ToString());
                if (i < b.Length) c += int.Parse(b[i].ToString());

                s = c > 1 ? $"{c - 2}{s}" : $"{c}{s}";
                c = c > 1 ? 1 : 0;
            }

            if (c > 0) return c > 1 ? $"{c - 2}{s}" : $"{c}{s}";
            return s;
        }

    }
}

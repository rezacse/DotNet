using System.Text;

namespace ProblemSolving.LeetCode.Completed;
public class ReformatPhoneNumber
{
    public string Format(string s)
    {
        StringBuilder r = new();
        StringBuilder lr = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= '0' && s[i] <= '9')
                lr.Append(s[i]);

            if (lr.Length == 3)
            {
                if (r.Length > 0) r.Append('-');

                r.Append(lr);
                lr.Clear();
            }
        }

        if (lr.Length == 2)
        {
            if (r.Length > 0) r.Append('-');
            r.Append(lr);
        }

        if (lr.Length == 1)
        {
            var last = r[r.Length - 1];
            r[r.Length - 1] = '-';
            r.Append(last).Append(lr);
        }
        return r.ToString();
    }
}

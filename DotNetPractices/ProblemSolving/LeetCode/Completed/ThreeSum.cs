namespace ProblemSolving.LeetCode.Completed;

public class ThreeSum
{

    public bool Is3SumEqual(int[] a)
    {
        int total = 0;
        foreach (int item in a) total += item;
        if (total % 3 != 0) return false;

        int nos = 0, s = 0;

        for (int i = 0; i < a.Length; i++)
        {
            s += a[i];
            if (s == (nos + 1) * total / 3) nos++;
        }
        return nos == 3;
    }
}

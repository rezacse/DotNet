class MaxIn3
{
    public int Solution(int l, int m, int n)
    {
        if (l > m && l > n) return l;
        else if (m > l && m > n) return m;
        return n;
    }
}

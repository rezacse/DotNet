class CountDiv
{
    public int Solution(int A, int B, int K)
    {
        if (A == B) return A % K == 0 ? 1 : 0;

        if (K > B) return 0;

        int e, cd;
        e = B - (B % K);
        cd = (e - A) / K + 1;

        return cd;
    }
}
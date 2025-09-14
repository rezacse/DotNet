class MissingElm
{

    public int missingElm(int[] A, int N)
    {
        int t = 0;
        for (int i = 0; i < N; i++)
        {
            t += N - i - A[i];
        }

        return N + 1 + t;
    }
}
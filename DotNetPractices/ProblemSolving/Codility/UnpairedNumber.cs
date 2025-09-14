class UnpairedNumber
{
    public int Solution(int[] A)
    {
        int n = 0;
        int len = A.Length;
        int ml = A.Length / 2;
        for (int i = 0; i < ml; i++)
        {
            n = n ^ A[i] ^ A[len - i - 1];
        }

        n = n ^ A[ml];

        return n;
    }
}



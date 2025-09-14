class PermCheck
{
    //100%
    public int Solution(int[] A)
    {
        int v, l = A.Length;
        var b = new bool[l];

        for (int i = 0; i < l; i++)
        {
            v = A[i];
            if (v > l || b[v - 1]) return 0;
            b[v - 1] = true;
        }

        return 1;
    }

    //83%: [9, 5, 7, 3, 2, 7, 3, 1, 10, 8]
    //int permCheck(int[] A, int N) {
    //    int i,r = A[0] - N;
    //    for(i=1; i<N; i++) {
    //        if(A[i]>N || A[i]==A[i-1]) break;
    //        r += A[i] - (N-i);
    //    }
    //
    //    return i==N && r == 0 ? 1 : 0;
    //}


}

class CyclicRotation
{

    public int[] Solution(int[] A, int K)
    {

        int l = A.Length;
        if (l == K || K == 0) return A;

        int k = K > l ? K % l : K;
        int t;
        for (int i = 0; i < k; i++)
        {
            t = A[l - 1];
            for (int j = l - 1; j > 0; j--)
            {
                A[j] = A[j - 1];
            }
            A[0] = t;
        }

        //print(A, l);

        return A;
    }

    //int * cyclicRotation(int[] A, int l, int K) {
    //
    //    if(l==K || K==0) {
    //        print(A, l);
    //        return A;
    //    }
    //
    //    int v = 0;
    //    int ti, t, tt;
    //
    //    t = A[0];
    //    for(int i = 0; v < l; ) {
    //
    //        ti = i + K;
    //        if(ti >= l) ti = ti%l;
    //
    //        tt = A[ti];
    //        A[ti] = t;
    //        t = tt;
    //
    //        i = ti;
    //        v++;
    //    }
    //
    //    print(A, l);
    //
    //    return A;
    //}

}
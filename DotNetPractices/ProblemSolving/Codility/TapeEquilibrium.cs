
using System;

class TapeEquilibrium
{

    public int Solution(int[] A)
    {
        int s = 0;
        for (int i = 0; i < A.Length; i++)
        {
            s += A[i];
        }

        int m = 100000000, ls = 0, d = 0;
        for (int i = 0; i < A.Length - 1; i++)
        {
            ls += A[i];
            s -= A[i];
            d = Math.Abs(s - ls);
            if (d < m) m = d;
        }

        return m;
    }

}
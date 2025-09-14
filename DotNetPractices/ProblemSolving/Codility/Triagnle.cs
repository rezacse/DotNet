using System;

class Triagnle
{
    public int Solution(int[] A)
    {
        Array.Sort(A);
        for (var i = 0; i < A.Length - 2; i++)
        {
            if (A[i + 2] - A[i + 1] < A[i]) return 1;

        }
        return 0;

        //int p = int.MinValue, q = int.MinValue, r = int.MinValue;
        //bool isChange;

        //foreach (var a in A)
        //{
        //    isChange = false;
        //    if (a > r)
        //    {
        //        p = q;
        //        q = r;
        //        r = a;
        //        isChange = true;
        //    }
        //    else if (a > q)
        //    {
        //        p = q;
        //        q = a;
        //        isChange = true;
        //    }
        //    else if (a > p)
        //    {
        //        p = a;
        //        isChange = true;
        //    }

        //    if (isChange && IsTriangle(p, q, r))
        //    {
        //        return 1;
        //    }

        //}

        //return 0;
    }

    //private bool IsTriangle(int p, int q, int r)
    //{
    //    return p - q > r && p - r > q && q - r > p;
    //}
}

class MaxProductOfThree
{
    public int Solution(int[] A, int N)
    {
        var b = new int[] { 1001, 1001, -1001, -1001, -1001 };
        for (int i = 0; i < N; i++)
        {
            if (A[i] > b[4])
            {
                b[2] = b[3];
                b[3] = b[4];
                b[4] = A[i];
            }
            else if (A[i] > b[3])
            {
                b[2] = b[3];
                b[3] = A[i];
            }
            else if (A[i] > b[2])
            {
                b[2] = A[i];
            }

            if (A[i] < b[0])
            {
                b[1] = b[0];
                b[0] = A[i];
            }
            else if (A[i] < b[1])
            {
                b[1] = A[i];
            }
        }

        int l = b[0] * b[1] * b[4];
        int m = b[2] * b[3] * b[4];

        return l > m ? l : m;

        //    int m = 0;
        //    if(b[0]*b[1]> b[2]*b[3]) m = b[0]*b[1];
        //    else  m = b[2]*b[3];
        //
        //    if(b[4]>b[3] && b[4]>b[2]) return b[4]*m;
        //    else if(b[3]>b[4] && b[3]>b[2]) return b[3]*m;
        //    return b[2]*m;

    }
}
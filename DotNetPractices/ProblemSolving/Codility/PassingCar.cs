class PassingCar
{
    //90%
    //int a[100000];
    //for(int i=0;i<100000;i++) {
    //    a[i] = i%2;
    //}
    public int Solution(int[] A)
    {

        int l = 0, pz = 0, len = A.Length;
        for (int i = 0; i < len; i++)
        {
            if (A[i] == 0)
            {
                l += len - (i + 1) - pz;
                pz++;
            }
        }

        return l > 1000000000 ? -1 : l;
    }

}
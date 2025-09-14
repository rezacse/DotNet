
int getMax(int a, int b)
{
    return a > b ? a : b;
}
int maxSum(int a[1000], int n)
{
    int m = a[0];

    //BETTER SOLUTION O(n)
    int lm = m;
    for (int i = 1; i < n; i++)
    {
        lm = getMax(lm + a[i], a[i]);
        m = getMax(m, lm);
    }

    //FIRST SOLUTION O(n*n)
    // for (int i = 0; i < n; i++)
    // {
    //     int lm = a[i];
    //     int temp = lm;
    //     for (int j = i+1; j < n; j++)
    //     {
    //         temp += a[j];
    //         lm = getMax(temp, lm);
    //     }
    //     m = getMax(m, lm);
    // }
    return m;
}
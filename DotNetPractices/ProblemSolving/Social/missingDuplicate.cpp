int missingDuplicate(int ar[100], int n)
{
    for(int i=1;i<n;i +=2)
    {
        if(ar[i-1] != ar[i])
            return ar[i-1];
    }

    return ar[n-1];
}

int missingValueInArray(int a[1001], int n)
{
    int i;
    int b[1001] = {0};

    for (i = 1; i < n; i++)
        b[a[i]]++;

    for (i = 1; i < n; i++)
    {
        if (b[i] == 0)
            return i;
    }
    return n;
}

void swap (int *a, int *b)
{
    int t = *a;
    *a = *b;
    *b = t;
}

void zigZagOrder(int ar[100], int n)
{
    for(int i=1;i<n;i++)
    {
        if(i%2 == 0 && ar[i-1]<ar[i])
            swap(&ar[i-1], &ar[i]);
        else if(i%2 != 0 && ar[i-1]>ar[i])
            swap(&ar[i-1], &ar[i]);
    }
}
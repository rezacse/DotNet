
int kthElement(int a[1000], int b[1000], int m, int n, int k)
{
    int i = 0, j = 0;
    bool isJ;
    while(i+j<k)
    {
        if(i<m && j<n && a[i]<=b[j])
        {
            i++;
            isJ = false;
        } else if(i==m) {
            j = k - i;
            isJ = true;
        }else if(j==n){
            i = k - j;
            isJ = false;
        } else {
            j++;
            isJ = true;
        }
    }

    return isJ ? b[j-1]: a[i-1];
}
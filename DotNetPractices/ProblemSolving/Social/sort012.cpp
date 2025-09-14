#include <iostream>

void sort012(int a[100], int n)
{
    int i, num;
    num = 3;
    int sortA[num] = {0};

    for (i = 0; i < n; i++)
        sortA[a[i]]++;

    for (i = 0; i < num; i++)
    {
        int k = 0;
        while (sortA[i] > k)
        {
            cout << i << " ";
            k++;
        }
    }
}
